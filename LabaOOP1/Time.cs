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
        public abstract string ShowTime();
    }

    public class TimeEuro : Time
    {
        CultureInfo myCIintl = new CultureInfo("es-ES", false);
        public override string ShowTime()
        {
            return DateTime.Now.ToString(myCIintl);
        }
    }
    public class TimeUS : Time
    {
        CultureInfo myCIintl = new CultureInfo("en-US", false);
        public override string ShowTime()
        {
            return DateTime.Now.ToString(myCIintl);
        }
    }
    public abstract class Decorator : Time
    {
        private Time _time; 
        
        public Decorator(Time time)
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
