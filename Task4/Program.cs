using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Car
    {
        public int Speed { get; set; }
        public event EventHandler SpeedEvent;
        public void SpeedChanging(int newSpeed)
        {
            Speed = newSpeed;
            SpeedEvent?.Invoke(this, EventArgs.Empty);
        }
    }
    public class SpeedMeter
    {
        private Car _car;
        public SpeedMeter(Car car)
        {
            _car = car;
            _car.SpeedEvent += SpeedView;
        }
        public void SpeedView(Object obj, EventArgs e)
        {
            Console.WriteLine("Current speed is : " + _car.Speed);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car bibiip = new Car();
            SpeedMeter sp1 = new SpeedMeter(bibiip);

            bibiip.SpeedChanging(80);
            bibiip.SpeedChanging(130);

            Console.ReadKey();
        }
    }
}
