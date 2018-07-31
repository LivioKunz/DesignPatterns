using System;

namespace FacadePattern
{
    public class ComplicatedProgramOne
    {
        public void WriteSomeStuff(string stuff)
        {
            Console.WriteLine($"Write: {stuff} in class {nameof(ComplicatedProgramOne)}");
        }
    }
}