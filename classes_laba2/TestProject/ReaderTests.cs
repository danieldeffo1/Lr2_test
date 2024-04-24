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
    public class ReaderTests
    {
        private string _zeroReviewsStatus = "0 reviews";

        [TestMethod]
        public void TestProperties()
        {
            var fio = "Петров Иван Иванович";
            var age = 50;
            var reader = new Reader(fio, age);
            var status_ = "Registered";
            Assert.AreEqual(fio, reader.FIO);
            Assert.AreEqual(age, reader.Age);
            Assert.AreEqual(status_, reader.Status);
        }

        [TestMethod]
        public void TestMethodsaddTicket()
        {
            var fio = "Петров Иван Иванович";
            var age = 50;
            var reader = new Reader(fio, age);
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
            reader.addTicket(ticket);

            Assert.AreEqual(ticket, reader.Ticket);

        }

    }
}
