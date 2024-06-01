using RobotService.Models.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Models
{
    public abstract class Robot : IRobot
    {
        private string model;
        private int batteryCapacity;
        private readonly List<int> interfaceStandats;

        public Robot(string model, int batteryCapacity, int conversionCapacityIndex)
        {
            model = Model;
            batteryCapacity = BatteryCapacity;
            conversionCapacityIndex = ConvertionCapacityIndex;
            interfaceStandats = new();
        }
        public string Model
        {
            get => model;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new AggregateException(ExceptionMessages.ModelNullOrWhitespace);
                }
                value = model;
            }
            
        }

        public int BatteryCapacity
        {
            get => batteryCapacity;
            private set
            {
                if (batteryCapacity<0)
                {
                    throw new AggregateException(ExceptionMessages.BatteryCapacityBelowZero);
                }
                value = batteryCapacity;
            }
        }

        public int BatteryLevel { get; private set; }

        public int ConvertionCapacityIndex { get; private set; }

        //A collection of all the supported connectivity standards by a specific Robot.
        public IReadOnlyCollection<int> InterfaceStandards => interfaceStandats;

        public void Eating(int minutes)
        {
            int capacity = batteryCapacity * minutes;
            if (capacity> BatteryCapacity - BatteryLevel)
            {
                BatteryLevel = BatteryCapacity; 
            }
            else
            {
                BatteryLevel += capacity;
            }
        }

        public bool ExecuteService(int consumedEnergy)
        {
            if (BatteryLevel>=consumedEnergy)
            {
                BatteryLevel -= consumedEnergy;
                return true;
            }
           return false;
        }

        public void InstallSupplement(ISupplement supplement)
        {
            //The InstallSupplemet() method takes the given supplement’s InterfaceStandard and adds it to the list of InterfaceStandards of the Robot.
            interfaceStandats.Add(supplement.InterfaceStandard);
            BatteryCapacity -= supplement.BatteryUsage;
            BatteryLevel -= supplement.BatteryUsage;
        }
        public override string ToString()
        {
            StringBuilder stringBuil= new StringBuilder();

            stringBuil.AppendLine($"{GetType().Name} {Model}");
            stringBuil.AppendLine($"--Maximum battery capacity: { BatteryCapacity}");
            stringBuil.AppendLine($"--Current battery level: {BatteryLevel}");
            //--Supplements installed: {standard1} {standard2}…/none"
            string supplemntsIntalled = InterfaceStandards.Any()
                ? $"{string.Join(" ", InterfaceStandards)}": "none" ;
            stringBuil.AppendLine($"--Supplements installed: {supplemntsIntalled}");

            //TrimEnd()->no add new line
            return stringBuil.ToString().TrimEnd();
        }

    }
}
