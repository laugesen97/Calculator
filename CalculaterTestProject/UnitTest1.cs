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

        [TestCase(2, 3, 8)]
        [TestCase(7, 2, 49)]
        [TestCase(5, 4, 625)]
        public void Power_AliftedB_isEqualC(double A, double B, double C)
        {
            Assert.That(uut.Power(A,B),Is.EqualTo(C));
        }

        [Test]
        public void Power_3lifted3_isEqual27()
        {
            Assert.That(uut.Power(3,3),Is.EqualTo(27));
        }

        [Test]
        public void Devide_4DevidedBy2_isEqual2()
        {
            Assert.That(uut.Devider(4,2),Is.EqualTo(2));
        }


        [TestCase(3,4,5)]
        [TestCase(10, 11, 14.9)]
        [TestCase(2,5,5.4 )]
        [Test]
        public void Pythagoras_a_Times_b_IsEqualc(double a, double b, double c)
        {
            Assert.That(uut.Pytagoras(a, b), Is.EqualTo(c));
        }

        [TestCase(6, 4, 10)]
        [TestCase(2, 1, 3)]
        [TestCase(6, -4, 2)]
        [TestCase(4,-4,0)]
        public void Add(int x, int y, int z)
        {
            Assert.AreEqual(uut.Add(x,y),z);
        }

       
    }
}