using System;

namespace AbstractFactoryPattern
{
    public class MainApp
    {
        public static void Main(string[] args)
        {
            AnimalWorld animalWorldEurope = new AnimalWorld(new EuropeFactory());
            animalWorldEurope.RunFoodChain();

            Console.ReadLine();

            AnimalWorld animalWorldAfrica = new AnimalWorld(new AfricaFactory());
            animalWorldAfrica.RunFoodChain();

            Console.ReadLine();
        }
    }

    public class AnimalWorld
    {
        private readonly Carnivore carnivore;
        private readonly Herbivore herbivore;

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