using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
        public static List<dynamic> Search(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return null;
            else if (!String.IsNullOrWhiteSpace(input) && int.TryParse(input, out int result))
                return null; //SearchTopic(result);
            else
                return SearchTopic(input);
        }
        
        public static List<dynamic> SearchTopic(int input, List<dynamic> list)
        {
            return list.Where(topic => topic.Id == input).ToList();
        }
        public static List<dynamic> SearchTopic(string input)
        {
            return null;
        }
    }
}
