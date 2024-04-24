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
    public class BookTests
    {
        [TestMethod]
        public void TestProperties()
        {
            Book book = new Book()
            {
                author = "Л. Н. Толстой",
                Name = "ВОЙНА И МИР",
                count = 2,
            };

            var author = "Л. Н. Толстой";
            var Name = "ВОЙНА И МИР";
            var count = 2;


            Assert.AreEqual(author, book.author);
            Assert.AreEqual(Name, book.Name);
            Assert.AreEqual(count, book.count);

        }


        [TestMethod]
        public void TestMethodChangeStatusBusy()
        {
            Book book = new Book()
            {
                author = "Л. Н. Толстой",
                Name = "ВОЙНА И МИР",
                count = 2,
            };
            book.ChangeStatusBusy();

            Assert.AreEqual("Busy", book.Status);

        }


        [TestMethod]
        public void TestMethodChangeStatusFree()
        {
            Book book = new Book()
            {
                author = "Л. Н. Толстой",
                Name = "ВОЙНА И МИР",
                count = 2,
            };
            book.ChangeStatusFree();

            Assert.AreEqual("Free", book.Status);

        }

    }
}
