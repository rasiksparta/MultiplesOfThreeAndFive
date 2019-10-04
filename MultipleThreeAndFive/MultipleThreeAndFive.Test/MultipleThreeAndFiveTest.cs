using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MultipleThreeAndFive.Test
{
    [TestFixture]
    class MultipleThreeAndFiveTest
    {
        MultipleThreeAndFive mtf = new MultipleThreeAndFive();

        [Test]
        public void TestIsMultipleOfThreeOrFive()
        {
            Assert.IsTrue(mtf.IsMultipleOfThreeOrFive(25));
            Assert.IsTrue(mtf.IsMultipleOfThreeOrFive(9));
            Assert.IsFalse(mtf.IsMultipleOfThreeOrFive(2));
        }

        [Test]
        public void TestNegativeInput()
        {
            Assert.Throws<NegativeInputException>(delegate { mtf.IsMultipleOfThreeOrFive(-1); });
        }

        [Test]
        public void TestRangeHasNegativeBound()
        {

        }

        [Test]
        public void TestRangeIsANullSet()
        {

        }

        [Test]
        public void TestSummationOfNumberList()
        {

        }
    }
}
