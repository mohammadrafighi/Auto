using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Massage
    {
        public string Text { get; set; }
        public DateTime datetime { get; set; } = DateTime.Now;
        public Employee Receiver { get; set; }
    }
}
