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
        [TestCase(234, 11, 245)]
        public void Add_AplusB_isEqualToC(double A, double B, double C)
        {
            Assert.That(uut.Add(A, B),Is.EqualTo(C));
        }

        [TestCase(11, 7, 4)]
        [TestCase(123, 23,100)]
        [TestCase(23,24, -1)]
        public void Subtract_AminusB_isEqualToC(double A, double B, double C)
        {
            Assert.That(uut.Subtract(A,B),Is.EqualTo(C));
        }

        [TestCase(2, 3, 6)]
        [TestCase(99, 10, 990)]
        [TestCase(12, 12, 144)]
        public void Multiply_AtimesB_isEqualToC(double A, double B, double C)
        {
            Assert.That(uut.Multiply(A,B),Is.EqualTo(C));
        }

        [TestCase(12, 3, 4)]
        [TestCase(144, 12, 12)]
        [TestCase(12.6, 3, 4.2)]
        public void Divider_aDvidedWithB_IsEqualToc(double a, double b, double c)
        {
            Assert.That(uut.Devider(a, b), Is.EqualTo(c));
        }

        [TestCase(2, 3, 8)]
        [TestCase(7, 2, 49)]
        [TestCase(5, 4, 625)]
        public void Power_AliftedB_isEqualtoC(double A, double B, double C)
        {
            Assert.That(uut.Power(A,B),Is.EqualTo(C));
        }


        [TestCase(3,4,5)]
        [TestCase(10, 11, 14.9)]
        [TestCase(2, 5, 5.4)]
        public void Pythagoras_a_Times_b_IsEqualtoc(double a, double b, double c)
        {
            Assert.That(uut.Pytagoras(a, b), Is.EqualTo(c));
        }

        [TestCase(3.5, 38.5)]
        [TestCase(2.0345, 13)]
        [TestCase(12.732, 509.3)]
        public void CirkleAreal_rpow2TimesPi_IsEqualToa(double r, double a)
        {
            Assert.That(uut.circleAreal(r), Is.EqualTo(a));
        }

    }
}