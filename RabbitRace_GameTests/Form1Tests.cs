using Microsoft.VisualStudio.TestTools.UnitTesting;
using RabbitRace_Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitRace_Game.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Logic chk = new Logic();
            chk.blnce = 50;
            if (chk.blnce > 0)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }
        [TestMethod()]
        public void Form2Test()
        {
            Logic chk = new Logic();
            chk.blnce = 50;
            if (chk.genrte() > 0)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

    }
}