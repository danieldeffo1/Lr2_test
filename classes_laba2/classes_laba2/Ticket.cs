using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_laba2
{
    public class Ticket : IObject
    {

        public List<Book> Books { get; set; }

        public Ticket(List<Book> books_)
        {
            Status = "created";
            Books = books_;
        }
        public int CountTakenBooks()
        {
            var count = Books.Count;
            if (Books.Count < 2)
                Status = "Can";
            else
                Status = "Impossible";
            return count;
        }

        public void addBook(Book book_)
        {
            Books.Add(book_);
            Status = "Received";
        }
        public void ReturnBook(Book book_)
        {
            Books.Remove(book_);
        }
    }
}
