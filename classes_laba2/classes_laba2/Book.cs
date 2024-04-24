using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace classes_laba2
{
    public class Book : IObject
    {


        public string author { get; set; }
        public string Name { get; set; }
        public int count { get; set; }


        public void ChangeStatusBusy()
        {
            Status = "Busy";
        }
        public void ChangeStatusFree()
        {
            Status = "Free";
        }


    }
}
