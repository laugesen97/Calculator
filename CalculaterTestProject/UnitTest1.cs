using System.Security.Cryptography.X509Certificates;
using Calculator;
using NUnit.Framework;

namespace CalculaterTestProject
{
    public class Tests
    {
        private CalculatorClass uut;
        [SetUp]
        public void Setup()
        {
            uut = new CalculatorClass();
        }

        [TestCase(2,4,6)]
        [TestCase(100, 450, 550)]
        [TestCase(234, 11,2, 245,2)]
        public void Add_AplusB_isEqualToC(double A, double B, double C)
        {
            Assert.That(uut.Add(A, B),Is.EqualTo(C));
        }

        [TestCase(11, 7, 4)]
        [TestCase(123, 23,1, 99,9)]
        [TestCase(23,24, 0,24, 23)]
        public void Subtract_AminusB_isEqualToC(double A, double B, double C)
        {
            Assert.That(uut.Subtract(A,B),Is.EqualTo(C));
        }

        [TestCase(2, 3, 6)]
        [TestCase(99, 10, 999)]
        [TestCase(12, 12, 144)]
        public void Multiply_AtimesB_isEqualToC(double A, double B, double C)
        {
            Assert.That(uut.Multiply(A,B),Is.EqualTo(C));
        }

        [TestCase(2, 3, 8)]
        [TestCase(7, 2, 49)]
        [TestCase(5, 4, 525)]
        public void Power_AliftedB_isEqualC(double A, double B, double C)
        {
            Assert.That(uut.Power(A,B),Is.EqualTo(C));
        }

        [TestCase(99, 10, 9,9)]
        [TestCase(49, 7,7)]
        [TestCase(22,2, 11,1, 2)]
        public void Devide_ADevidedByB_isEqualC(double A, double B, double C)
        {
            Assert.That(uut.Devider(A,B),Is.EqualTo(C));
        }
    }
}