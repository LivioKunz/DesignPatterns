using System;

namespace AbstractFactoryPattern
{
    public abstract class Carnivore
    {
        public abstract void Eat(Herbivore herbivore);
    }

    public class Lion : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            Console.WriteLine(this.GetType().Name + " eats " + herbivore.GetType().Name);
        }
    }

    public class Wulf : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            Console.WriteLine(this.GetType().Name + " eats " + herbivore.GetType().Name);
        }
    }
}