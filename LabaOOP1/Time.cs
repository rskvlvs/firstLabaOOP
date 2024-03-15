using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LabaOOP1
{
    public abstract class Time
    {
        public CultureInfo myCIintl;

        public abstract string ShowTime();

        public Time(CultureInfo myCIintl)
        {
            this.myCIintl = myCIintl;
        }
    }

    public class TimeEuro : Time 
    {
        public TimeEuro() : base(new CultureInfo("es-ES", false)) { }

        public override string ShowTime()
        {
            return DateTime.Now.ToString(myCIintl);
        }
    }

    public class TimeUS : Time
    {
        public TimeUS() : base(new CultureInfo("en-US", false)) { }

        public override string ShowTime()
        {
            return DateTime.Now.ToString(myCIintl);
        }
    }

    public abstract class Decorator : Time
    {
        private Time _time; 
        
        public Decorator(Time time):base(time.myCIintl)
        {
            _time = time;
        }

        public override string ShowTime()
        {
            return _time.ShowTime();
        }
    }

    public class TimeEuDecorator : Decorator
    {
        public TimeEuDecorator(TimeEuro timeEuro) : base(timeEuro) { }

        public override string ShowTime()
        {
            StringBuilder sb = new StringBuilder(base.ShowTime());
            sb.Append("!!!!!");
            return sb.ToString();
        }
    }

    public class TimeUSDecorator : Decorator
    {
        public TimeUSDecorator(TimeUS timeUS) : base(timeUS) { }

        public override string ShowTime()
        {
            StringBuilder sb = new StringBuilder(base.ShowTime());
            sb.Append("!!!!!");
            return sb.ToString();
        }
    }
}
