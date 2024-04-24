using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_laba2
{
    public class Library : IObject
    {

        public string Name { get; private set; }
        public Catalog Catalog { get; private set; }

        public Library(string name)
        {
            Status = "Open";
            Name = name;
        }

        public void addCatalog(Catalog сatalog_)
        {
            Catalog = сatalog_;
        }

        public void GetStatus()
        {

            if (Catalog.countAvailableBooks() == 0)
                Status = "No books";
            else
                Status = "Open";

        }
    }
}
