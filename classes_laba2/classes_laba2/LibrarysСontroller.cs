using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace classes_laba2
{
    public class LibrarysСontroller
    {

        public List<Reader> readers = new List<Reader>();
        public List<Library> librarys = new List<Library>();




        public LibrarysСontroller()
        {
            // Создаем библиотеку и каталог библиотеки
            var library1 = new Library("Библиотека-читальня имени И. С. Тургенева");

            var books = new List<Book>()
            {
                new Book()
                {
                    author = "Л. Н. Толстой",
                    Name = "ВОЙНА И МИР",
                    count = 2,
                },

                new Book()
                {
                    author = "Н. В. Гоголь",
                    Name = "МЕРТВЫЕ ДУШИ",
                    count = 1,
                },

                new Book()
                {
                    author = "Сергей Лукьяненко",
                    Name = "Вечный дозор",
                    count = 1,
                },

                new Book()
                {
                    author = "Марк Аврелий",
                    Name = "Наедине с собой. Размышления",
                    count = 1,
                }

            };
            var catalog = new Catalog(books);
            library1.addCatalog(catalog);

            // Создаем читателя и его читательский билет
            var reader1 = new Reader("Петров Иван Иванович", 50);

            var booksTicket1 = new List<Book>()
            {
                new Book()
                {
                    author = "Л. Н. Толстой",
                    Name = "ВОЙНА И МИР",
                    count = 1,
                },


                new Book()
                {
                    author = "Марк Аврелий",
                    Name = "Наедине с собой. Размышления",
                    count = 1,
                }

            };


            var ticket1 = new Ticket(booksTicket1);
            reader1.addTicket(ticket1);

            librarys.Add(library1);
            readers.Add(reader1);
        }

        public void Script1()
        {
            // Читатель хочет взять книгу в библиотеке
            var library = librarys[0];
            var catalog = library.Catalog;
            int maximum_number_books_per_person = 2;
            var reader = readers[0];
            var ticket = reader.Ticket;
            var countAvailableBooks = catalog.countAvailableBooks();

            Console.WriteLine($"The number of available books in the library {countAvailableBooks}");

            if (ticket.CountTakenBooks() == maximum_number_books_per_person)
            {
                Console.WriteLine($"You cannot give out more than {maximum_number_books_per_person} books");
            }
            else
            {
                var book = new Book()
                {
                    author = "Сергей Лукьяненко",
                    Name = "Вечный дозор",
                    count = 1,
                };
                bool statusFoundBook = catalog.FindBook(book);
                if (statusFoundBook == true)
                {
                    ticket.addBook(book);
                    Console.WriteLine("The book has been issued");
                }
            }

        }

        public void Script2()
        {
            // Читатель хочет вернуть книгу
            var library = librarys[0];
            var catalog = library.Catalog;
            var reader = readers[0];
            var ticket = reader.Ticket;
            var countAvailableBooks = catalog.countAvailableBooks();

            Console.WriteLine($"The number of available books in the library {countAvailableBooks}");
            var book = new Book()
            {
                author = "Сергей Лукьяненко",
                Name = "Вечный дозор",
                count = 1,
            };
            ticket.ReturnBook(book);
            catalog.AddBook(book);

            countAvailableBooks = catalog.countAvailableBooks();
            Console.WriteLine($"The number of available books in the library after the return: {countAvailableBooks}");
        }


    }
}
