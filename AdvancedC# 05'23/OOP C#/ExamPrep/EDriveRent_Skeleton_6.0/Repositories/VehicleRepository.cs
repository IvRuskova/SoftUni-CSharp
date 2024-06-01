using EDriveRent.Models.Contracts;
using EDriveRent.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDriveRent.Repositories
{
    internal class VehicleRepository : IRepository<IVehicle>
    {
        private List<IVehicle> vehicles;
        public VehicleRepository() 
        {
            vehicles = new List<IVehicle>();
        }
        public void AddModel(IVehicle model)
        {
            this.vehicles.Add(model);
        }

        public IVehicle FindById(string identifier)
        {
            return this.vehicles.FirstOrDefault(v=>v.LicensePlateNumber == identifier);
        }

        public IReadOnlyCollection<IVehicle> GetAll()
        {
            return this.vehicles;
        }

        public bool RemoveById(string identifier)
        {
           
            return this.vehicles.Remove(FindById(identifier));
        }
    }
}
