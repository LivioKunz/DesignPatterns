using System;

namespace SingletonPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Universe universeOne = Universe.Instance();
            universeOne.Size = 4;
            Console.WriteLine($"UniverseOne has size: {universeOne.Size}");

            Universe universeTwo = Universe.Instance();
            Console.WriteLine($"UniverseTwo has size: {universeTwo.Size}");


            AlternateUniverse alternateUniverse = AlternateUniverse.GetAlternateUniverse();
            alternateUniverse.Size = 5;
            AlternateUniverse alternatedUniverseNew = AlternateUniverse.GetAlternateUniverse();
            Console.WriteLine($"Alternate Universe Size: {alternatedUniverseNew.Size}");

            Console.Read();
        }
    }


    public class Universe
    {
        private static Universe instance;
        public int Size { get; set; }

        public static Universe Instance()
        {
            if (instance == null) instance = new Universe();
            return instance;
        }
    }

    public class AlternateUniverse
    {
        private static readonly AlternateUniverse Instance = new AlternateUniverse();
        public int Size { get; set; }

        public static AlternateUniverse GetAlternateUniverse()
        {
            return Instance;
        }
    }
}