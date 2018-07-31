using System;
using System.Collections.Generic;

namespace VisitorPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Employees employees = new Employees();
            employees.Attach(new Clerk("Hank", 25000, 14));
            employees.Attach(new Director("Elly", 35000.0, 16));
            employees.Attach(new President("Trump", 10000000.0, 200));

            employees.Accept(new IncomeVisitor());
            employees.Accept(new VacationVisitor());
        }
    }

    public interface IVisitor
    {
        void Visist(Element element);
    }

    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }

    internal class VacationVisitor : IVisitor
    {
        public void Visist(Element element)
        {
            Employee employee = element as Employee;
            // Provide 3 extra vacation days
            employee.VacationDays += 3;
            Console.WriteLine("{0} {1}'s new vacation days: {2}", employee.GetType().Name, employee.Name,
                employee.VacationDays);
        }
    }

    public class IncomeVisitor : IVisitor
    {
        public void Visist(Element element)
        {
            Employee employee = element as Employee;

            // Provide 10% pay raise
            employee.Income *= 1.10;
            Console.WriteLine("{0} {1}'s new income: {2:C}", employee.GetType().Name, employee.Name, employee.Income);
        }
    }

    public class Employee : Element
    {
        public Employee(string name, double income, int vacationDays)
        {
            this.Name = name;
            this.Income = income;
            this.VacationDays = vacationDays;
        }

        public double Income { get; set; }
        public string Name { get; set; }
        public int VacationDays { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visist(this);
        }
    }


    internal class Employees
    {
        private readonly List<Employee> EmployeesList = new List<Employee>();

        public void Attach(Employee employee)
        {
            this.EmployeesList.Add(employee);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (Employee employee in this.EmployeesList) employee.Accept(visitor);
        }
    }

    internal class President : Employee
    {
        public President(string name, double income, int vacationDays) : base(name, income, vacationDays)
        {
        }
    }

    internal class Director : Employee
    {
        public Director(string name, double income, int vacationDays) : base(name, income, vacationDays)
        {
        }
    }

    internal class Clerk : Employee
    {
        public Clerk(string name, double income, int vacationDays) : base(name, income, vacationDays)
        {
        }
    }
}