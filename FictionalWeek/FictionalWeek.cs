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