using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Lektion01.UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_2And4_Returns6()
        {
            var uut = new Calculator();

            Assert.That(uut.Add(2,4), Is.EqualTo(6));
        }
        
        [Test]
        public void Subtract_0And0Returns1()
        {
            var uut = new Calculator();

            Assert.That(uut.Subtract(0,0), Is.EqualTo(1));
        }
        
        [Test]
        public void Add_Minus5And2_ReturnsMinus3()
        {
            var uut = new Calculator();

            Assert.That(uut.Add(-5,2), Is.EqualTo(-3));
        }

        [Test]
        public void Add_Minus2AndMinus4_ReturnsMinus6()
        {
            var uut = new Calculator();

            Assert.That(uut.Add(-2,-4), Is.EqualTo(-6));
        }

        [Test]
        public void Subtract_2And4_ReturnsMinus2()
        {
            var uut = new Calculator();
            
            Assert.That(uut.Subtract(2,4), Is.EqualTo(-2));
        }

        [TestCase(3, -5, 8)]
        [TestCase(-3,-3, 0)]
        public void Subtract_Multiple_ReturnsCorrect(double a, double b, double c)
        {
            var uut = new Calculator();
            Assert.That(uut.Subtract(a,b), Is.EqualTo(c));
        }

        [TestCase(3, 3, 9)]
        [TestCase(-3,3,-9)]
        [TestCase(-3,-3,9)]
        public void Multiply_Multiple_ReturnsCorrect(double a, double b, double c)
        {
            var uut = new Calculator();
            Assert.That(uut.Multiply(a,b), Is.EqualTo(c));
        }

        [TestCase(2,2,4)]
        [TestCase(-2,2,4)]
        [TestCase(1,-2, 1)]
        public void Power_Multple_ReturnsCorrect(double a, double b, double c)
        {
            var uut = new Calculator();
            Assert.That(uut.Power(a,b), Is.EqualTo(c));
        }
    }
}
