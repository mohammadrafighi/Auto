using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Auto
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<Massage> Massages { get; set; } = new List<Massage>();

        public void SendmassagePrivate(string username, string text)
        {
            var receiver = Employees.FirstOrDefault(e => e.Username == username);
            if (receiver == null)
            {
                Console.WriteLine($"{username} not found");
                return;
            }

            Massages.Add(new Massage { Receiver = receiver, Text = text });

        }
        public void SendmassageRole(string role, string text)
        {
            var receivers = Employees.ToList().Where(em => em.Role == role).ToList();
            if (receivers.Count == 0)
            {
                Console.WriteLine($"{role} not found");
                return;
            }
            foreach (var e in receivers)
            {
                Massages.Add(new Massage { Receiver = e, Text = text });
            }
        }
        public void SendmassagePublic(string text)
        {
            Massages.Add(new Massage { Receiver = null, Text = text });
        }
        public void Showpublic()
        {
            Console.WriteLine("Public Massages :");
            var publicmsgs = Massages.Where(m => m.Receiver == null);
            foreach (var msg in publicmsgs)
            {
                Console.WriteLine(msg.Text);
            }
        }
        public void Showprivate(string username)
        {
            Console.WriteLine($"Texts of {username} :");
            var msgs = Massages.Where(m => m.Receiver != null && m.Receiver.Username == username);
            foreach (var msg in msgs)
            {
                Console.WriteLine(msg.Text);
            }
        }

    }
}
