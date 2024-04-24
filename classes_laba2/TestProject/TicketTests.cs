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
    public class TicketTests
    {
        [TestMethod]
        public void TestProperties()
        {
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

            CollectionAssert.AreEqual(booksTicket, ticket.Books);
        }

        [TestMethod]
        public void TestMethodCountTakenBooks()
        {
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
            int count = ticket.CountTakenBooks();
            var count_ = 2;
            var status_ = "Impossible";
            Assert.AreEqual(count_, count);
            Assert.AreEqual(status_, ticket.Status);


        }
    }
}
