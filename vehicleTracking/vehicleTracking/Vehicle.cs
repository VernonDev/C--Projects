using System;

namespace vehicleTracking;

public class Vehicle
{
     // Variable declaration.
        public string make = "";
        public string model = "";
        public int condition = 0;
        public double price = 0;

// Empty constructor.
public Vehicle()
{
} 


        // Constructor.
public Vehicle(string newMake, string newModel, int newCondition, double newPrice)
{
   make = newMake;
   model = newModel;
   condition = newCondition;
   price = newPrice;
}
}
