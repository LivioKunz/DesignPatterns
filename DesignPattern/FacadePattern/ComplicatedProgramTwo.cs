using System;

namespace FacadePattern
{
    public class ComplicatedProgramTwo
    {
        public void WriteSomeOtherStuff(string stuff)
        {
            Console.WriteLine($"Write: {stuff} in class {nameof(ComplicatedProgramTwo)}");
        }
    }
}