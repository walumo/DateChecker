using System;

namespace DateChecker
{
    public class Checker
    {
        public static bool IsInFuture(DateTime date)
        {
            if (date.CompareTo(DateTime.Now) < 0)
                return true;
            else
                return false;
        }
    }
}
