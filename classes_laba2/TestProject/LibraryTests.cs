using Microsoft.VisualStudio.TestTools.UnitTesting;
using classes_laba2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class LibraryTests
    {
        [TestMethod]
        public void TestPropertiesAndConstructor()
        {
            var name = "Библиотека-читальня имени И. С. Тургенева";
            Library library = new Library(name);
            var status_ = "Open";
            Assert.AreEqual(name, library.Name);
            Assert.AreEqual(status_, library.Status);
        }

        [TestMethod]
        public void TestaddCatalog()
        {
            var name = "Библиотека-читальня имени И. С. Тургенева";
            Library library = new Library(name);
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
            library.addCatalog(catalog);
            Assert.AreEqual(catalog, library.Catalog);
        }

        [TestMethod]
        public void TestMethodGetStatus()
        {
            var name = "Библиотека-читальня имени И. С. Тургенева";
            Library library = new Library(name);
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
            library.addCatalog(catalog);
            library.GetStatus();
            var status_ = "Open";
            Assert.AreEqual(status_, library.Status);
        }
    }
}
