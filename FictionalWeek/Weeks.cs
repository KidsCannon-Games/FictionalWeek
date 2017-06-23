using System;

namespace FictionalWeek
{
    public class Weeks
    {
        private const int WeeksInMonth = 4;
        private const int WeeksInYear = 4 * 12;

        // 0-origin
        private int _internalWeek = 0;

        public void Reset ()
        {
            _internalWeek = 0;
        }

        public void Next ()
        {
            _internalWeek += 1;
        }

        public void Prev ()
        {
            if (_internalWeek > 0)
            {
                _internalWeek -= 1;
            }
        }

        public bool IsMatch(string year, string month, string week)
        {
            if (year == null) throw new ArgumentException("year must not be null");
            if (year != "*")
            {
                int y;
                int.TryParse(year, out y);
                if (y < 1) throw new ArgumentException("year must be greater than or equal to 1");
            }
            if (month == null) throw new ArgumentException("month must not be null");
            if (month != "*")
            {
                int m;
                int.TryParse(month, out m);
                if (m < 1 || m > 12) throw new ArgumentException("month must be greater than or equal to 1 and less than or equal to 12");
            }
            if (week == null) throw new ArgumentException("week must not be null");
            if (week != "*")
            {
                int w;
                int.TryParse(week, out w);
                if (w < 1) throw new ArgumentException("week must be greater than or equal to 1");
            }

            if (year != "*" && year != Year().ToString())
            {
                return false;
            }
            if (month != "*" && month != Month().ToString())
            {
                return false;
            }

            return week == "*" || week == Week().ToString();
        }

        // 1-origin
        public int Week()
        {
            return _internalWeek % WeeksInMonth + 1;
        }

        // 1-origin
        public int Month()
        {
            return _internalWeek % WeeksInYear / WeeksInMonth + 1;
        }

        // 1-origin
        public int Year()
        {
            return (_internalWeek / WeeksInYear + 1);
        }
    }
}
