using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resturant
{
    class Order
    {
        public int Number { get; set; }
        public DateTime datetime { get;  set; } = DateTime.Now;
        public List<Orderitem> Items { get;  set; } = new List<Orderitem>();
        public double Discount { get; set; }
        public double Subtotal => Items.Sum(i => i.Totalprice);
        public void CalDiscount()
        {
            int mainorder = Items.Where(i => i.Item.Category == "Mains").Sum(i => i.Quantity);
            double Dis = 0;
            if (mainorder > 3)
            {
                Dis += 0.05;
            }
            if (Subtotal > 10000)
            {
                Dis += 0.10;
            }
            Discount = Subtotal * Dis;
        }

        public double total
        {
            get
            { return Subtotal - Discount; }
        }
        public void Additem(Menuitem item,int quantity)
        {
            Items.Add(new Orderitem(item,quantity));
            
        }
       
        public void Showinvoice()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine($"-----------Invoice number:{Number}");
            Console.WriteLine($"-----------Date and Time:{datetime}");
            Console.WriteLine($"Items----------------Quantity--------------Price-----------------Total");
            foreach(var orderitem in Items)
            {
                Console.WriteLine($"{orderitem.Item.Name} ------- {orderitem.Quantity}----------------------{orderitem.Item.Price}--------------------------{orderitem.Totalprice} dollars");
            }
            Console.WriteLine("------------------------------------------------------");
            CalDiscount();
            Console.WriteLine($"Subtotal is: {Subtotal} dollars");
            Console.WriteLine($"Discount is: {Discount} dollars");
            Console.WriteLine($"total is: {total} dollars");
            Console.WriteLine("------------------------------------------------------");
        }

       
        public void Pay()
        {
            Console.WriteLine("Please pay.....And enter Y/N");
            string x = Console.ReadLine().ToLower();
            if (x == "y")
            {
                Console.WriteLine("Please wait...");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("*Your order is ready*");
            }
            else
            {
                Console.WriteLine("Pay is not successfull");
                Pay();
            }
            
        }
        

    }
 
}
