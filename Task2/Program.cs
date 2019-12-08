using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    interface iAnimal
    {
    }
    class Panda : iAnimal
    {
    }
    class Bear : iAnimal
    {
    }
    class Racoon : iAnimal
    {
    }

    class Zoo
    {
        public List<iAnimal> zooPark = new List<iAnimal>();
    }
    class Program
    {
        static void Main(string[] args)
        {
            iAnimal milacha = new Panda();
            iAnimal someGrizly = new Bear();
            iAnimal rocket = new Racoon();

            Zoo zoo = new Zoo();

            zoo.zooPark.Add(milacha);
            zoo.zooPark.Add(someGrizly);
            zoo.zooPark.Add(rocket);

        }
    }
}
