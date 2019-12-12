using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;
using Task1.Interfaces;


namespace Task1.Classes
{
    public class Airbus : ICargoPlane
    {
        public Airbus(string name, int speed, int fuelConsumption, int fuelCapacity, int carryingCapacity)
        {
            Name = name;
            Speed = speed;
            FuelConsumption = fuelConsumption;
            FuelCapacity = fuelCapacity;
            CarryingCapacity = carryingCapacity;
        }
        public string Name{ get; private set; }
        public int Speed{ get; private set; }
        public int CarryingCapacity { get; private set; }
        public int FuelConsumption{ get; private set; }
        public int FuelCapacity{ get; private set; }      

        public int GetCarryingWeight()
        {
            return CarryingCapacity;
        }
        public decimal GetFlyDistance()
        {
            return (Speed * FuelCapacity / FuelConsumption) * 1000 / GetCarryingWeight();
        }
        public string GetInfo()
        {
            return string.Format("Cargo plane: {0}, speed:{1}, carrying weight:{2}, fuel consumption: {3}",
                Name, Speed, GetCarryingWeight(), FuelConsumption);
        }
    }
}
