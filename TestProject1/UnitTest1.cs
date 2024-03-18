using LabaOOP1;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        [TestCase(4, 3, 3, 5, 29, 15)]
        [TestCase(1, 9, 3, 9, 4, 9)]
        public void plus(int a1, int a2, int b1, int b2, int r1, int r2)
        {
            drobi a = new drobi(a1, a2);
            drobi b = new drobi(b1, b2);

            drobi fact = a + b;

            Assert.That(fact.Numerator == r1, Is.True);
            Assert.That(fact.Denominator == r2, Is.True);
        }
        [Test]
        [TestCase(4, 3, 3, 5, 11, 15)]
        [TestCase(6, 10, -3, 5, 6, 5)]
        public void minus(int a1, int a2, int b1, int b2, int r1, int r2)
        {
            drobi a = new drobi(a1, a2);
            drobi b = new drobi(b1, b2);

            drobi fact = a - b;

            Assert.That(fact.Numerator == r1, Is.True);
            Assert.That(fact.Denominator == r2, Is.True);
        }
        [Test]
        [TestCase(4, 3, 3, 5, 6, 10)]
        [TestCase(6, 10, -3, 5, -9, 25)]
        public void umno(int a1, int a2, int b1, int b2, int r1, int r2)
        {
            drobi a = new drobi(a1, a2);
            drobi b = new drobi(b1, b2);

            drobi fact = a * b;

            Assert.That(fact.Numerator == r1, Is.True);
            Assert.That(fact.Denominator == r2, Is.True);
        }
        [Test]
        [TestCase(4, 3, 3, 5, 20, 9)]
        [TestCase(2, 3, -3, 15, -10, 3)]
        public void del(int a1, int a2, int b1, int b2, int r1, int r2)
        {
            drobi a = new drobi(a1, a2);
            drobi b = new drobi(b1, b2);

            drobi fact = a / b;

            Assert.That(fact.Numerator == r1, Is.True);
            Assert.That(fact.Denominator == r2, Is.True);
        }
        [Test]
        [TestCase(4, 3, 7, 3)]
        [TestCase(3, 4, 7, 4)]
        public void unoPlus(int a1, int a2, int r1, int r2)
        {
            drobi a = new drobi(4, 3);
            a++;

            Assert.That(a.Numerator == r1, Is.True);
            Assert.That(a.Denominator == r2, Is.True);
        }
        [Test]
        [TestCase(4, 3, 1, 3)]
        [TestCase(3, 4, -1, 4)]
        public void unoMinus(int a1, int a2, int r1, int r2)
        {
            drobi a = new drobi(4, 3);
            a--;

            Assert.That(a.Numerator == r1, Is.True);
            Assert.That(a.Denominator == r2, Is.True);
        }
        [Test]
        [TestCase(4, 3, 3, 5, false)]
        [TestCase(2, 4, 1, 2, true)]
        public void equal(int a1, int a2, int b1, int b2, bool res)
        {
            drobi a = new drobi(4, 3);
            drobi b = new drobi(3, 5);

            bool fact = a == b;

            Assert.That(fact == res, Is.True);
            Assert.That(fact == res, Is.True);
        }
        [Test]
        [TestCase(4, 3, 3, 5, true)]
        [TestCase(2, 4, 1, 2, false)]
        public void notEqual(int a1, int a2, int b1, int b2, bool res)
        {
            drobi a = new drobi(4, 3);
            drobi b = new drobi(3, 5);

            bool fact = a != b;

            Assert.That(fact == res, Is.True);
            Assert.That(fact == res, Is.True);

        }
        [Test]
        [TestCase(4, 3, 3, 5, true)]
        [TestCase(3, 5, 4, 3, false)]
        public void bigger(int a1, int a2, int b1, int b2, bool res)
        {
            drobi a = new drobi(4, 3);
            drobi b = new drobi(3, 5);

            bool fact = a > b;

            Assert.That(fact == res, Is.True);
            Assert.That(fact == res, Is.True);
        }
        [Test]
        public void lower()
        {
            drobi a = new drobi(4, 3);
            drobi b = new drobi(3, 5);

            bool equals = false;
            bool fact = a < b;

            Assert.That(equals == fact, Is.True);

            equals = true;
            fact = b < a;

            Assert.That(equals == fact, Is.True);
        }
        public void notLower()
        {
            drobi a = new drobi(4, 12);
            drobi b = new drobi(1, 3);

            bool equals = true;
            bool fact = a <= b;

            Assert.That(equals == fact, Is.True);

            a = new drobi(5, 2);
            b = new drobi(3, 2);

            equals = false;
            fact = a <= b;

            Assert.That(equals == fact, Is.True);
        }
        [Test]
        public void notBigger()
        {
            drobi a = new drobi(4, 12);
            drobi b = new drobi(2, 3);

            bool equals = false;
            bool fact = a >= b;

            Assert.That(equals == fact, Is.True);

            a = new drobi(5, 2);
            b = new drobi(3, 2);

            equals = true;
            fact = a >= b;

            Assert.That(equals == fact, Is.True);
        }
        
        [Test]
        public void checkZeroDen()
        {
            Assert.Throws<ArgumentException>(delegate { new drobi(4, 0); });
        }
    }
}