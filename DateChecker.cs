using System;
using System.Collections.Generic;
using System.Linq;

namespace Utility
{
    public class DateChecker
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

    public class Query
    {
        public static IQueryable Search(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return null;
            else if (!String.IsNullOrWhiteSpace(input) && int.TryParse(input, out int result))
                return SearchTopic(result);
            else
                return SearchTopic(input);
        }

        public static IQueryable SearchTopic(int input)
        {
            return null;
        }
        public static IQueryable SearchTopic(string input)
        {
            return null;
        }
    }
}
