using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    [TestFixture]
    public class TestCase
    {
        [TestCase]
        public void Add()
        {
            Maths maths = new Maths();
            Assert.AreEqual(31, maths.Add(20, 11));
        }

        [TestCase]
        public void Subtract()
        {
            Maths maths = new Maths();
            Assert.AreEqual(9, maths.Subtract(20, 11));
        }
    }
}
