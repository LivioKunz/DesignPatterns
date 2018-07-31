using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Facade
    {
        //Vereinfacht zugriff auf andere 2 Methoden da nur eine Aufgerufen werden muss -> Bäm Facade
        public void WriteStuff()
        {
            var complicatedProgramOne = new ComplicatedProgramOne();
            complicatedProgramOne.WriteSomeStuff();

            ComplicatedProgramTwo complicatedProgramTwo = new ComplicatedProgramTwo();
            complicatedProgramTwo.WriteSomeOtherStuff();
        }


        
    }



    public class ComplicatedProgramOne
    {
        public void WriteSomeStuff()
        {
            Console.WriteLine("Testi");
        }

        
    }


    public class ComplicatedProgramTwo
    {
        public void WriteSomeOtherStuff()
        {
            Console.WriteLine("Testi van Test");
        }
    }
}
