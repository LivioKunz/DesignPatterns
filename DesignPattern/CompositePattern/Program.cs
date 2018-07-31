using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var deparmentManagerIT = new Manager("Livio","0798115303","IT");
            deparmentManagerIT.AddEmployee(new AtomicEmployee("Peter","alskdjf"));
            deparmentManagerIT.AddEmployee(new AtomicEmployee("Peter2","alskdjf"));
            deparmentManagerIT.AddEmployee(new AtomicEmployee("Peter3","alskdjf"));

            var deparmentManagerHR = new Manager("HR","skldjf","HR");
            deparmentManagerHR.AddEmployee(new AtomicEmployee("Stufe 1", "sdklf"));
            deparmentManagerHR.AddEmployee(new AtomicEmployee("Stufe 1", "sdklf"));
            deparmentManagerIT.AddEmployee(deparmentManagerHR);

            deparmentManagerIT.AddEmployee(new Manager("TestManager under HR","sdklf", "NOT_HR"));


            //Mitarbeiterhierarchie nutzen
            Console.WriteLine(deparmentManagerIT.GetNumberOfEmployees());
            deparmentManagerIT.Print("   ");
        }
    }

    public class AtomicEmployee : Employee
    {
        

        public AtomicEmployee(string name, string number) : base(name, number)
        {
        }

        public override int GetNumberOfEmployees()
        {
            return 1;
        }

        public override void Print(string space)
        {
            Console.WriteLine(space + this.Name + "Tel: " + TelephoneNumber);
        }
    }


    public abstract class Employee
    {
        public string Name { get; set; }
        public string TelephoneNumber { get; set; }

        public Employee(string name, string number)
        {
            this.Name = name;
            this.TelephoneNumber = number;
        }

        public abstract int GetNumberOfEmployees();


        public abstract void Print(string space);
    }
}
