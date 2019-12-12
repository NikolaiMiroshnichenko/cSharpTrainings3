using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public interface iAnimal
    {
    }
    public class Panda : iAnimal
    {
    }
    public class Bear : iAnimal
    {
    }
    public class Racoon : iAnimal
    {
    }
    public class Zoo
    {
        private List<iAnimal> zooPark = new List<iAnimal>();
        public void AddToZooparck(iAnimal animal)
        {
            zooPark.Add(animal);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            iAnimal milacha = new Panda();
            iAnimal someGrizly = new Bear();
            iAnimal rocket = new Racoon();            

            zoo.AddToZooparck(milacha);
            zoo.AddToZooparck(someGrizly);
            zoo.AddToZooparck(rocket);
        }
    }
}
