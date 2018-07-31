using System;

namespace DecoratorPattern
{
    public class Merchant : Character
    {
        public override void Say()
        {
            Console.WriteLine("Wanna buy stuff?");
        }
    }
}