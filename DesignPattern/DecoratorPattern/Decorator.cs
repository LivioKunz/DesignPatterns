using System;

namespace DecoratorPattern
{
    public abstract class Decorator : Character
    {
        private readonly Character myCharacter;

        protected Decorator(Character character)
        {
            this.myCharacter = character;
        }

        public override void Say()
        {
            this.myCharacter.Say();
        }
    }


    public class CoughDecorator : Decorator
    {
        public CoughDecorator(Character character) : base(character)
        {
        }

        public override void Say()
        {
            Console.WriteLine("Cough, Cough...");
            base.Say();
        }
    }

    public class SnifflesDecorator : Decorator
    {
        public SnifflesDecorator(Character character) : base(character)
        {
        }

        public override void Say()
        {
            Console.WriteLine("Sniff, Sniff...");
            base.Say();
        }
    }
}