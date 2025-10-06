using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resturant
{
    class Program
    {
        static void Main(string[] args)
        {
            resturant Mrpizza = new resturant { Name = "Mrpizza", Address = "Karaj", Phone = "2512", Credit = "61042278", Type = "Fastfood" };

            Staff Manager = new Staff { Name = "Hasan", Role = "Manager", Salary = 100 };

            Staff Chef = new Staff { Name = "Ali", Role = "Chef", Salary = 70 };

            Staff Garson = new Staff { Name = "Reza", Role = "Garson", Salary = 60 };
            Mrpizza.Addstaff(Manager);
            Mrpizza.Addstaff(Chef);
            Mrpizza.Addstaff(Garson);
            Table A = new Table { Name = 'A', Capacity = 5 };
            Table B = new Table { Name = 'B', Capacity = 7 };
            Table C = new Table { Name = 'C', Capacity = 8 };
            Mrpizza.Addtable(A);
            Mrpizza.Addtable(B);
            Mrpizza.Addtable(C);
            Menuitem Specialpizza = new Menuitem { Name = "Special pizza", Price = 400, Category = "Mains" };
            Menuitem Peperonipizza = new Menuitem { Name = "Peperoni pizza", Price = 300, Category = "Mains" };
            Menuitem Italianpizza = new Menuitem { Name = "Italian pizza", Price = 300, Category = "Mains" };
            Menuitem Sezarsalad = new Menuitem { Name = "Sezar salad", Price = 200, Category = "Salads" };
            Menuitem SpecialSezarsalad = new Menuitem { Name = "Special sezar salad", Price = 300, Category = "Salads" };
            Menuitem Cola = new Menuitem { Name = "Cola", Price = 50, Category = "Drinks" };
            Menuitem Delester = new Menuitem { Name = "Delester", Price = 50, Category = "Drinks" };
            Menu Main = new Menu { };
            Main.Addmains(Specialpizza);
            Main.Addmains(Peperonipizza);
            Main.Addmains(Italianpizza);
            Main.Addsalads(Sezarsalad);
            Main.Addsalads(SpecialSezarsalad);
            Main.Adddrinks(Cola);
            Main.Adddrinks(Delester);
           
            Order one = new Order { Number = 1 };
            one.Additem(Specialpizza, 4);
            one.Additem(Sezarsalad, 2);
            one.Additem(Cola, 6);


            Mrpizza.Getinfo();
            Main.Showmenu();
            one.Showinvoice();
            one.Pay();
            Console.ReadKey();


        }
    }
}
