using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using classes_laba2;

namespace TestProject
{
    [TestClass]
    public class ScenesTest
    {
        private LibrarysСontroller controller = new LibrarysСontroller();
        [TestMethod]
        public void TestScript1()
        {
            controller.Script1();
        }

        [TestMethod]
        public void TestScript2()
        {
            controller.Script2();
        }

    }
}
