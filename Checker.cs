using System;

namespace DateChecker
{
    public class Checker
    {
        public static bool IsInFuture(DateTime date)
        {
            if (date.CompareTo(DateTime.Now) > 0)
                return true;
            else
                return false;
        }

        public static bool IsLate(DateTime startLearningDate, decimal hoursToComplete)
        {
            if (startLearningDate.AddHours(Convert.ToDouble(hoursToComplete)).CompareTo(DateTime.Now) <= 0)
                return true;
            else
                return false;
        }
        public static bool IsLate(DateTime startLearningDate, double hoursToComplete)
        {
            if (startLearningDate.AddHours(hoursToComplete).CompareTo(DateTime.Now) <= 0)
                return true;
            else
                return false;
        }
    }
}
