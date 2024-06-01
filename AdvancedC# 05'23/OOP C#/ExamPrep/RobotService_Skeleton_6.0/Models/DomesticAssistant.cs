using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Models
{
    public class DomesticAssistant : Robot
    {
        private const int DomesticAssistantbatteryCapacity = 20_000;
        private const int DomesticAssistantconversionCapacityIndex = 2_000;
        public DomesticAssistant(string model) : base(model, DomesticAssistantbatteryCapacity, DomesticAssistantconversionCapacityIndex)
        {   
        }
    }
}
