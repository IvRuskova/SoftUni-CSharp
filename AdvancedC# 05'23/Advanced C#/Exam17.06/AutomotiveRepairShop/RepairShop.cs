namespace AutomotiveRepairShop
{
    public class RepairShop
    {
        List<Vehicle>  vehicles;
        public int Capacity { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        public RepairShop(int capacity)
        {
                Capacity = capacity;
                Vehicles = new List<Vehicle>();
        }
        public void AddVehicle(Vehicle vehicle)
        {
            if (Vehicles.Count < Capacity)
            {
                Vehicles.Add(vehicle);
            }
        }

        public bool RemoveVehicle(string vin)
        {
            Vehicle vehicle = Vehicles.Find(v => v.VIN == vin);
            if (vehicle != null)
            {
                Vehicles.Remove(vehicle);
                return true;
            }
            return false;
        }

        public int GetCount()
        {
            return Vehicles.Count;
        }

        public Vehicle GetLowestMileage()
        {
            Vehicle lowestMileageVehicle = null;
            int minMileage = int.MaxValue;

            foreach (var vehicle in Vehicles)
            {
                if (vehicle.Mileage < minMileage)
                {
                    lowestMileageVehicle = vehicle;
                    minMileage = vehicle.Mileage;
                }
            }

            return lowestMileageVehicle;
           
        }
        public string Report()
        {
            return "Vehicles in the preparatory:" + string.Join(" ", Vehicles);
        }
    }
}
