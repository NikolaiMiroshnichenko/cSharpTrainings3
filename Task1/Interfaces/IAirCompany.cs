using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Interfaces
{
    public interface IAirCompany
    {
        string Name { get; }
        ICollection<IPlane> Planes { get; }
        void AddPlane(IPlane plane);
        void RemovePlane(IPlane plane);
        int GetTotalCapacity();
        int GetTotalCarryingWeight();
        IEnumerable<IPlane> SortPlanesByFlyDistance();
        IEnumerable<IPlane> FindPlaneByFuelConsumption(int startValue, int endValue);
    }
}
