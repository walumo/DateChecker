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

        public static bool IsLate(DateTime startLearningDate, DateTime deadline, decimal hoursToComplete)
        {
            if (startLearningDate.AddHours(Convert.ToDouble(hoursToComplete)).CompareTo(deadline) >= 0)
                return true;
            else
                return false;
        }
    }
}
