using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;

namespace Task1.Classes
{
    public class ANSportsPlane : ISportsPlane
    {
        private const int OnePassengerWeight = 90;
        public ANSportsPlane(string name, int speed, int fuelConsumption, int fuelCapacity, int crewNumber)
        {
            Name = name;
            Speed = speed;            
            CrewNumber = crewNumber;
            FuelConsumption = fuelConsumption;
            FuelCapacity = fuelCapacity;
        }
        public string Name{ get; private set; }
        public int Speed{ get; private set; }

        public int FuelConsumption{ get; private set; }
        public int FuelCapacity{ get; private set; }
        public int CrewNumber{ get; private set; }

        public string Airdrop()
        {
            return "airdrop";
        }
        public int GetCarryingWeight()
        {
            return CrewNumber * OnePassengerWeight;
        }
        public decimal GetFlyDistance()
        {
            return (Speed * FuelCapacity / FuelConsumption) * 1000 / GetCarryingWeight();
        }
        public string GetInfo()
        {
            return string.Format("Sports plane: {0}, speed:{1},crew number:{2}, fuel consumption:{3}",
                Name, Speed, CrewNumber, FuelConsumption);
        }
    }
}
