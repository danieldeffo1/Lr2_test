using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using classes_laba2;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class StatusTest
    {

        [TestMethod]
        public void Test1()
        {
            Library library = new Library("Библиотека-читальня имени И. С. Тургенева");
            Assert.AreEqual("Open", library.Status);

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

            };
            var catalog = new Catalog(books);
            Assert.AreEqual("Free", catalog.Status);

            var reader = new Reader("Петров Иван Иванович", 50);
            Assert.AreEqual("Registered", reader.Status);

            var booksTicket = new List<Book>() { };
            var ticket = new Ticket(booksTicket);
            Assert.AreEqual("created", ticket.Status);
        }

        [TestMethod]
        public void Test2()
        {
            Library library = new Library("Библиотека-читальня имени И. С. Тургенева");
            Assert.AreEqual("Open", library.Status);

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
            Assert.AreEqual("Free", catalog.Status);

            var reader = new Reader("Петров Иван Иванович", 50);
            Assert.AreEqual("Registered", reader.Status);

            var booksTicket = new List<Book>()
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
            var ticket = new Ticket(booksTicket);
            ticket.CountTakenBooks();
            Assert.AreEqual("Impossible", ticket.Status);
        }

        [TestMethod]
        public void Test3()
        {
            Library library = new Library("Библиотека-читальня имени И. С. Тургенева");
            Assert.AreEqual("Open", library.Status);

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
            Assert.AreEqual("Free", catalog.Status);

            var reader = new Reader("Петров Иван Иванович", 50);
            Assert.AreEqual("Registered", reader.Status);

            var booksTicket = new List<Book>()
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
            var ticket = new Ticket(booksTicket);
            ticket.CountTakenBooks();
            Assert.AreEqual("Impossible", ticket.Status);

            var book = new Book()
            {
                author = "Сергей Лукьяненко",
                Name = "Вечный дозор",
                count = 1,
            };
            bool statusFoundBook = catalog.FindBook(book);
            Assert.AreEqual("In stock", catalog.Status);
        }


        [TestMethod]
        public void Test4()
        {
            Library library = new Library("Библиотека-читальня имени И. С. Тургенева");
            Assert.AreEqual("Open", library.Status);

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
            Assert.AreEqual("Free", catalog.Status);

            var reader = new Reader("Петров Иван Иванович", 50);
            Assert.AreEqual("Registered", reader.Status);

            var booksTicket = new List<Book>()
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
            var ticket = new Ticket(booksTicket);
            ticket.CountTakenBooks();
            Assert.AreEqual("Impossible", ticket.Status);

            var book = new Book()
            {
                author = "Сергей Лукьяненко1",
                Name = "Вечный дозор",
                count = 1,
            };
            bool statusFoundBook = catalog.FindBook(book);
            Assert.AreEqual("Out of stock", catalog.Status);
        }
    }
}
