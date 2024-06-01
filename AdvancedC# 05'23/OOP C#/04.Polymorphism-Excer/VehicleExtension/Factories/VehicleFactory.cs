﻿using System;
using Raiding.Factories.Interfaces;
using Raiding.Models;
using Raiding.Models.Interfaces;

namespace Raiding.Factories;

public class VehicleFactory : IVehicleFactory
{
    public IVehicle Create(string type, double fuelQuantity, double fuelConsumption, double tankCapacity)
    {
        switch (type)
        {
            case "Car":
                return new Car(fuelQuantity, fuelConsumption, tankCapacity);
            case "Truck":
                return new Truck(fuelQuantity, fuelConsumption, tankCapacity);
            case "Bus":
                return new Bus(fuelQuantity, fuelConsumption, tankCapacity);
            default:
                throw new ArgumentException("Invalid vehicle type");
        }
    }
}