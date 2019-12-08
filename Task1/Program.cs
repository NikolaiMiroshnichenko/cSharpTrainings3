using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    interface IFly
    {
        void move();
    }
    interface IDrive
    {
        void move();
    }

    class Plain:IFly, IDrive
    {
public void move ()
        {
            Console.WriteLine("I move");
        }


    }
    class Program
    {

        static void Main(string[] args)
        {
            IFly fly = new Plain();
            IDrive drive = new Plain();
            Plain plain = new Plain();
            fly.move(); drive.move(); plain.move();
            Console.ReadKey();
        }
    }
}
