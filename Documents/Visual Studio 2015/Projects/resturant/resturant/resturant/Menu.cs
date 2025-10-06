using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resturant
{
    class Menu
    {
        public List<Menuitem> Mains { get; set; } = new List<Menuitem>();
        public List<Menuitem> Salads { get; set; } = new List<Menuitem>();
        public List<Menuitem> Drinks { get; set; } = new List<Menuitem>();
        public void Addmains(Menuitem item)
        {
            Mains.Add(item);
        }
        public void Addsalads(Menuitem item)
        {
            Salads.Add(item);
        }
        public void Adddrinks(Menuitem item)
        {
            Drinks.Add(item);
        }
        public void Showmenu()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("The Menu is:");
            foreach(var item in Mains)
            {
                Console.WriteLine($"{item.Name} - {item.Price} dollars");
            }
            foreach (var item in Salads)
            {
                Console.WriteLine($"{item.Name} - {item.Price} dollars");
            }
            foreach (var item in Drinks)
            {
                Console.WriteLine($"{item.Name} - {item.Price} dollars");
            }
        }
    }
}
