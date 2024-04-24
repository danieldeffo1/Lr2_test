using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_laba2
{
    public class Librarian : IObject
    {
        public string FIO { get; private set; }

        public int Age { get; private set; }



        public Librarian(string fio, int age)
        {
            FIO = fio;
            Age = age;
            Status = "At work";
        }

        public void ComeToWork()
        {
            Status = "At work";
        }
        public void OutWork()
        {
            Status = "Out work";
        }
    }
}
