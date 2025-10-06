using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resturant
{
    class Orderitem
    {
        public Menuitem Item { get; set; }
        public int Quantity { get; set; }
        
        public double Totalprice
        {
            get
            {
                return Item.Price * Quantity;
            }
        }
        public Orderitem(Menuitem item,int quantity)
        {
            Item = item;
            Quantity = quantity;
        }



    }
}
