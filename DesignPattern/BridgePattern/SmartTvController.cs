using System;
using Console = System.Console;

namespace BridgePattern
{
    public class SmartTvController
    {
        public static void Main(string[] args)
        {
            SuperSmartTv myTv = new SuperSmartTv();

            Console.WriteLine("Select A source to get TV Guide and Play");
            Console.WriteLine("1. Local Cable TV\n2. Local Dish TV\n3. IP TV");

            ConsoleKeyInfo input = Console.ReadKey();

            // Let us see what user has selected and select the video source accrodingly
            switch (input.KeyChar)
            {
                case '1':
                    myTv.VideoSource = new LocalCableTv();
                    break;

                case '2':
                    myTv.VideoSource = new LocalDishTv();
                    break;

                case '3':
                    myTv.VideoSource = new InternetTv();
                    break;
            }

            Console.WriteLine(); //some whitespace on output for readability

            //Let us show the TV guide from selected source
            myTv.ShowTvGuide();

            //Let us now play the selected TV source.
            myTv.PlayTv();

            Console.WriteLine(); //some whitespace on output for readability
        }
    }
}
