using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resturant
{
    class resturant
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Credit { get; set; }
        public string Type { get; set; }
      
        public List<Staff> Staffs { get; set; } = new List<Staff>();
        public List<Table> Tables { get; set; } = new List<Table>();
        
     
        public void Addstaff(Staff staff)
        {
            Staffs.Add(staff);
        }
        public void Addtable(Table table)
        {
            Tables.Add(table);
        }
     
        public void Getinfo()
        {
            Console.WriteLine($"The name of resturant is:{Name}");
            Console.WriteLine($"The address of resturant is:{Address}");
            Console.WriteLine($"The phone of resturant is:{Phone}");
            Console.WriteLine($"The credit of resturant is:{Credit}");
            Console.WriteLine($"The type of resturant is:{Type}");
        }

    }
}
