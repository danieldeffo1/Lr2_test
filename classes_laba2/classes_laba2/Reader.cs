using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace classes_laba2
{
    public class Reader : IObject
    {

        public string FIO { get; private set; }

        public int Age { get; private set; }
        public Ticket Ticket { get; private set; }



        public Reader(string fio, int age)
        {
            FIO = fio;
            Age = age;
            Status = "Registered";
        }

        public void addTicket(Ticket ticket_)
        {
            Ticket = ticket_;

        }

    }
}
