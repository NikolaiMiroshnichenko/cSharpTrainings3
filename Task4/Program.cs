using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Car
    {
        public int speed { get; set; }
        public event EventHandler speedEvent;
        public void speedChanging(int newSpeed)
        {
            speed = newSpeed;
            speedEvent?.Invoke(this, EventArgs.Empty);
        }

    }
    class SpeedMeter
    {
        private Car _car;
        public SpeedMeter(Car car)
        {
            _car = car;
            _car.speedEvent += speedView;
        }
        public void speedView(Object obj, EventArgs e)
        {
            Console.WriteLine("Current speed is : " + _car.speed);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car bibiip = new Car();
            SpeedMeter sp1 = new SpeedMeter(bibiip);

            bibiip.speedChanging(80);
            bibiip.speedChanging(130);

            Console.ReadKey();
        }
    }
}
