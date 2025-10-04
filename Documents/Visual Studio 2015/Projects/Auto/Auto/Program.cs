using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Program
    {
        static void Main(string[] args)
        {
            Part IT = new Part
            {
                Name = "IT"
            };
            Part Commercial = new Part
            {
                Name = "Commercial"
            };
            Employee Ali = new Employee
            {
                Username = "Ali",
                Part = IT,
                Role = "Manager"
            };
            Employee Reza = new Employee
            {
                Username = "Reza",
                Part = IT,
                Role = "Employee1"
            };
            Employee Sara = new Employee
            {
                Username = "Sara",
                Part = Commercial,
                Role = "Manager"
            };
            Employee Javad = new Employee
            {
                Username = "Javad",
                Part = Commercial,
                Role = "Employee1"
            };
            Auto auto = new Auto();
            auto.Employees.Add(Ali);
            auto.Employees.Add(Reza);
            auto.Employees.Add(Sara);
            auto.Employees.Add(Javad);

            auto.SendmassagePrivate("Ali", "You must pay for dinner");
            auto.SendmassagePrivate("Sara", "Ali will pay for dinner");
            auto.SendmassagePublic("You are invited to dinner");
            auto.SendmassagePrivate("Akbar", "Salam Sara");
            auto.SendmassageRole("Manager", "Managers have a prize next week");

            auto.Showprivate("Ali");
            auto.Showprivate("Sara");
            auto.Showpublic();

            Console.ReadKey();

        }
    }
}
