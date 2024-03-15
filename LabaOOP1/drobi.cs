using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LabaOOP1
{
    public class drobi
    {
        private float numerator;
        private float denominator;

        //Геттер и сеттер
        public float Numerator
        {
            get { return numerator; }
            private set { numerator = value; }
        }
        public float Denominator { 
            get { return denominator; }
            private set { denominator = value; }
        }

        public drobi(float a, float b) {
            if(b == 0)
            {
                throw new ArgumentException("Делитель не может быть равен 0", nameof(b));
            }
            for (float del = Math.Abs(a); del > 0; del--)
            {
                if(Math.Abs(b) % del == 0 && Math.Abs(a) % del == 0)
                {
                    a /= del;
                    b /= del;
                }
            }

            Numerator = a;
            Denominator = b;
            
        }

        public override string ToString()
        {
            if (Math.Abs(Denominator) == 1 && (Numerator < 0 && Denominator > 0) || (Numerator > 0 && Denominator < 0)) return ("-" + Math.Abs(Numerator).ToString());
            else if (Math.Abs(Denominator) == 1) return (Math.Abs(Numerator).ToString());
            else if((Numerator < 0 && Denominator > 0) || (Numerator > 0 && Denominator < 0)) return ("-" + Math.Abs(Numerator).ToString() + "/" + Math.Abs(Denominator).ToString());
            return (Numerator.ToString() + "/" + Denominator.ToString());
        }

        public float getNumerator()
        {
            return (Numerator);
        }

        public float getDenominator()
        {
            return (Denominator);
        }

        public static drobi operator *(drobi first, drobi second)
        {
            return (new drobi(first.Numerator * second.Numerator, first.Denominator * second.Denominator));
        }

        public static drobi operator /(drobi first, drobi second)
        {
            return (new drobi(first.Numerator * second.Denominator, first.Denominator * second.Numerator));
        }

        public static drobi operator - (drobi first, drobi second)
        {
            return(new drobi(first.numerator * second.denominator - second.numerator * first.denominator, first.denominator * second.denominator));
        }

        public static drobi operator --(drobi first)
        {
            first = first - new drobi (1, 1);
            return first; 
        }

        public static drobi operator +(drobi first, drobi second)
        {
            return (new drobi(first.Numerator * second.Denominator + second.Numerator * first.Denominator, first.Denominator * second.Denominator));
        }

        public static drobi operator ++(drobi first)
        {
            drobi second = new drobi(1, 1);
            first = first + second;
            return first;
        }

        public static bool operator ==(drobi first, drobi second)
        {
            if(ReferenceEquals(first, second)) return true;
            return false; 
        }

        public static bool operator !=(drobi first, drobi second)
        {
            return !(first == second);
        }

        public static bool operator >(drobi first, drobi second)
        {
            return (first.Numerator / first.Denominator > second.Numerator / second.Denominator); 
        }

        public static bool operator < (drobi first, drobi second)
        {
            return (first.Numerator/first.Denominator < second.Numerator / second.Denominator);
        }

        public static bool operator <= (drobi first, drobi second)
        {
            return !(first > second);
        }

        public static bool operator >= (drobi first, drobi second)
        {
            return !(first < second);
        }
    }
  
}

