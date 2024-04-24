using Microsoft.VisualStudio.TestTools.UnitTesting;
using classes_laba2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;


namespace TestProject
{
    [TestClass]
    public class CatalogTests
    {
        [TestMethod]
        public void TestPropertiesAndConstructor()
        {
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
            CollectionAssert.AreEqual(books, catalog.Books);
        }

        [TestMethod]
        public void TestMethodcountAvailableBooks()
        {
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
            catalog.countAvailableBooks();
            Assert.AreEqual(5, catalog.countAvailableBooks());
        }

        [TestMethod]
        public void TestMethodFindBook()
        {
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
            var book = new Book()
            {
                author = "Сергей Лукьяненко",
                Name = "Вечный дозор",
                count = 1,
            };
            var catalog = new Catalog(books);
            bool statusFoundBook = catalog.FindBook(book);
            Assert.AreEqual(true, statusFoundBook);
        }


        [TestMethod]
        public void TestMethodAddBook()
        {
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
            var book_ = new Book()
            {
                author = "Сергей Лукьяненко",
                Name = "Вечный дозор",
                count = 1,
            };
            catalog.AddBook(book_);
            var author = book_.author;
            var Name = book_.Name;
            int count = 0;
            foreach (Book book in catalog.Books)
            {
                if (book.author == author && book.Name == Name)
                {
                    count = book.count;
                    break;
                }

            }

            Assert.AreEqual(2, count);
        }
    }
}
