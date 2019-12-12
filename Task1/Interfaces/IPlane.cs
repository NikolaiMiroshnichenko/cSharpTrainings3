using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Interfaces
{
    public interface IPlane
    {
        string Name{ get; }
        int Speed{ get; }
        int FuelConsumption{ get; }
        int FuelCapacity{ get; }
        decimal GetFlyDistance();
        int GetCarryingWeight();
        string GetInfo();
    }
}
