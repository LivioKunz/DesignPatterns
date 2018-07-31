using System;
using System.Collections.Generic;

namespace CompositePattern
{
    internal class Manager : Employee
    {
        public override void Print(string abstand)
        {
            Console.WriteLine(abstand + "Abteilungsleiter " + this.Name + " (" + this.Department + "). Tel: " + this.TelephoneNumber);
            foreach (Employee employee in this.Employees)
            {
                employee.Print(abstand + "      ");//Einrückung
            }
        }

        public List<Employee> Employees;
        public string Department { get; set; }

        public Manager(string name, string number, string department) : base(name, number)
        {
            this.Department = department;
            this.Employees = new List<Employee>();
        }

        public override int GetNumberOfEmployees()
        {
            int numberOf = 1;
            foreach (Employee employe in this.Employees)
            {
                numberOf += employe.GetNumberOfEmployees();
            }

            return numberOf;
        }

        public void AddEmployee(Employee employee)
        {
            this.Employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {

            this.Employees.Remove(employee);
        }

        public Employee GetEmployee(int index)
        {
            return this.Employees[index];
        }


    }
}