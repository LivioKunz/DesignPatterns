using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class MainApp
    {
        public static void Main(string[] args)
        {
            var animalWorldEurope = new AnimalWorld(new EuropeFactory());
            animalWorldEurope.RunFoodChain();

            Console.ReadLine();

            var animalWorldAfrica = new AnimalWorld(new AfricaFactory());
            animalWorldAfrica.RunFoodChain();

            Console.ReadLine();
        }
    }

    public class AnimalWorld
    {
        private Herbivore herbivore;
        private Carnivore carnivore;

        public AnimalWorld(ContinentFactory factory)
        {
            this.herbivore = factory.CreateHerbivore();
            this.carnivore = factory.CreateCarnivore();
        }

        public void RunFoodChain()
        {
            this.carnivore.Eat(this.herbivore);
        }
    }
}
