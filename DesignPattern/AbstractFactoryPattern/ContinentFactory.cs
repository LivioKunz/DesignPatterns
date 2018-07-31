namespace AbstractFactoryPattern
{
    public abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();

    }

    public class EuropeFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Cow();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Wulf();
        }
    }

    public class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Elephant();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}