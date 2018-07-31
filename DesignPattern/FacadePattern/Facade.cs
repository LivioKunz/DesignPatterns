using System;

namespace FacadePattern
{
    public class MainApp
    {
        public static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.WriteStuff("Bla Bla Bla");

            Console.ReadLine();
        }
    }

    public class Facade
    {
        public void WriteStuff(string stuff)
        {
            ComplicatedProgramOne complicatedProgramOne = new ComplicatedProgramOne();
            complicatedProgramOne.WriteSomeStuff(stuff);

            ComplicatedProgramTwo complicatedProgramTwo = new ComplicatedProgramTwo();
            complicatedProgramTwo.WriteSomeOtherStuff(stuff);
        }
    }
}