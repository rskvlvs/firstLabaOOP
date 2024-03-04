using LabaOOP1;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void plus()
        {
            drobi a = new drobi(4, 3);
            drobi b = new drobi(3, 5); 

            drobi equals = new drobi(29, 15);
            drobi fact = a + b;

            Assert.That(equals.getNumerator() == fact.getNumerator(), Is.True);
            Assert.That(equals.getDenominator() == fact.getDenominator(), Is.True);
        }
        [Test]
        public void minus()
        {
            drobi a = new drobi(4, 3);
            drobi b = new drobi(3, 5);

            drobi equals = new drobi(11, 15);
            drobi fact = a - b;

            Assert.That(equals.getNumerator() == fact.getNumerator(), Is.True);
            Assert.That(equals.getDenominator() == fact.getDenominator(), Is.True);
        }
        [Test]
        public void umno()
        {
            drobi a = new drobi(4, 3);
            drobi b = new drobi(3, 5);

            drobi equals = new drobi(12, 15);
            drobi fact = a * b;

            Assert.That(equals.getNumerator() == fact.getNumerator(), Is.True);
            Assert.That(equals.getDenominator() == fact.getDenominator(), Is.True);
        }
        [Test]
        public void del()
        {
            drobi a = new drobi(4, 3);
            drobi b = new drobi(3, 5);

            drobi equals = new drobi(20, 9);
            drobi fact = a / b;

            Assert.That(equals.getNumerator() == fact.getNumerator(), Is.True);
            Assert.That(equals.getDenominator() == fact.getDenominator(), Is.True);
        }
        [Test]
        public void unoPlus()
        {
            drobi a = new drobi(4, 3);

            drobi equals = new drobi(7, 3);
            a++;

            Assert.That(equals.getNumerator() == a.getNumerator(), Is.True);
            Assert.That(equals.getDenominator() == a.getDenominator(), Is.True);
        }
        [Test]
        public void unoMinus()
        {
            drobi a = new drobi(4, 3);

            drobi equals = new drobi(1, 3);
            a--;

            Assert.That(equals.getNumerator() == a.getNumerator(), Is.True);
            Assert.That(equals.getDenominator() == a.getDenominator(), Is.True);
        }
        [Test]
        public void equal()
        {
            drobi a = new drobi(4, 3);
            drobi b = new drobi(3, 5);

            bool equals = false; 
            bool fact = a == b;

            Assert.That(equals == fact, Is.True);
        }
        [Test]
        public void notEqual()
        {
            drobi a = new drobi(4, 3);
            drobi b = new drobi(3, 5);

            bool equals = true;
            bool fact = a != b;

            Assert.That(equals == fact, Is.True);
        }
        [Test]
        public void bigger()
        {
            drobi a = new drobi(4, 3);
            drobi b = new drobi(3, 5);

            bool equals = true;
            bool fact = a > b;

            Assert.That(equals == fact, Is.True);
        }
        [Test]
        public void lower()
        {
            drobi a = new drobi(4, 3);
            drobi b = new drobi(3, 5);

            bool equals = false;
            bool fact = a < b;

            Assert.That(equals == fact, Is.True);
        }
        public void notLower()
        {
            drobi a = new drobi(4, 12);
            drobi b = new drobi(1, 3);

            bool equals = true;
            bool fact = a <= b;

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
        }
        
        [Test]
        public void checkZeroDen()
        {
            Assert.Throws<ArgumentException>(delegate { new drobi(4, 0); });
        }
    }
}