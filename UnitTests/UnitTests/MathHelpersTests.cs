using NUnit.Framework;
using System;

namespace UnitTests
{
    [TestFixture]
    public class MathHelpersTests
    {
        private MathsHelper _sut;
        private int result;

        [OneTimeSetUp]
        public void Init()
        {
            _sut = new MathsHelper();
        }


        [Test]
        public void AddTest_WithBothPositiveParameters_ReturnsCorrectResult()
        {
            result = _sut.Add(15, 20);
            Assert.AreEqual(35, result);
        }

        [Test]
        public void AddTest_WithBothNegativeParameters_ReturnsCorrectResult()
        {
            result = _sut.Add(-10, -5);
            Assert.AreEqual(-15, result);
        }

        [Test]
        public void AddTest_WithOneNegativeAndOnePositiveParam_ReturnsCorrectResult()
        {
            result = _sut.Add(2, -15);
            Assert.AreEqual(-13, result);
        }

        [Test]
        public void AddTest_AddZero_ReturnsCorrectResult()
        {
            result = _sut.Add(50, 0);
            Assert.AreEqual(50, result);
        }


        [Test]
        public void Add_NegativeTestCase()
        {
            result = _sut.Add(10, 10);
            Assert.AreNotEqual(100, result);
        }

        [Test]
        public void SubstractTest_WithPositiveParameters_ReturnsCorrectResult()
        {
            result = _sut.Subtract(100, 40);
            Assert.AreEqual(60, result);
        }

        [Test]
        public void SubstractTest_WithNegativeParameters_ReturnsCorrectResult()
        {
            result = _sut.Subtract(-10, -40);
            Assert.AreEqual(30, result);
        }

        [Test]
        public void SubstractTest_WithOneNegativeAndOnePositiveParam_ReturnsCorrectResult()
        {
            result = _sut.Subtract(-10, 40);
            Assert.AreEqual(-50, result);
        }

        [Test]
        public void Substract_NegativeTestCase()
        {
            result = _sut.Subtract(10, 5);
            Assert.AreNotEqual(50, result);
        }

        [Test]
        public void DivideTest_PositiveTestCase()
        {
            result = _sut.Devide(25, 5);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Divide_NegativeTestCase()
        {
            result = _sut.Devide(9, 3);
            Assert.AreNotEqual(1, result);
        }

        [Test]
        public void DivideTest_OneDevidedByNine_ReturnsZero()
        {
            result = _sut.Devide(1, 9);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.That(() => _sut.Devide(2, 0), Throws.TypeOf<DivideByZeroException>());
        }
    }
}
