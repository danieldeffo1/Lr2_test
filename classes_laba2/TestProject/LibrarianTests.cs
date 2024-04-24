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
    public class LibrarianTests
    {
        [TestMethod]
        public void TestPropertiesAndConstructor()
        {
            var FIO = "Сидорова Сирафима Анатольевна";
            var age = 70;
            var status_ = "At work";

            Librarian librarian = new Librarian(FIO, age);


            Assert.AreEqual(FIO, librarian.FIO);
            Assert.AreEqual(age, librarian.Age);
            Assert.AreEqual(status_, librarian.Status);
        }

        [TestMethod]
        public void TestMethodComeToWork()
        {
            var FIO = "Сидорова Сирафима Анатольевна";
            var age = 70;
            var status_ = "At work";

            Librarian librarian = new Librarian(FIO, age);
            librarian.ComeToWork();
            Assert.AreEqual(status_, librarian.Status);
        }

        [TestMethod]
        public void TestMethodOutWork()
        {
            var FIO = "Сидорова Сирафима Анатольевна";
            var age = 70;
            var status_ = "Out work";

            Librarian librarian = new Librarian(FIO, age);
            librarian.OutWork();
            Assert.AreEqual(status_, librarian.Status);
        }
    }
}
