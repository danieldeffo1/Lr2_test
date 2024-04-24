using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_laba2
{
    public class Catalog : IObject
    {

        public List<Book> Books { get; set; }

        public Catalog(List<Book> books_)
        {
            Books = books_;
            Status = "Free";
        }

        public int countAvailableBooks()
        {
            int count = 0;
            foreach (Book book in Books)
            {
                count += book.count;
            }

            if (count > 0)
            {
                Status = "In stock";
            }
            else
            {
                Status = "Out of stock";
            }
            return count;
        }

        public bool FindBook(Book book_)
        {
            var author = book_.author;
            var Name = book_.Name;
            var count = book_.count;
            foreach (Book book in Books)
            {
                if (book.author == author && book.Name == Name && book.count > 0)
                {
                    book.count -= 1;
                    Status = "In stock";
                    return true;
                }

            }
            Status = "Out of stock";
            return false;
        }

        public void AddBook(Book book_)
        {
            var author = book_.author;
            var Name = book_.Name;
            foreach (Book book in Books)
            {
                if (book.author == author && book.Name == Name)
                {
                    book.count += 1;
                    return;
                }

            }
        }
    }
}
