using Raiding.Models.Interfaces;

namespace Raiding.Factories.Interfaces;

public interface IVehicleFactory
{
    IVehicle Create(string type, double fuelQuantity, double fuelConsumption, double tankCapacity);
}