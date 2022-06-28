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
        public static List<T> Search<T>(string input, List<T> list)
        {
            if (String.IsNullOrWhiteSpace(input))
                return null;
            else if (!String.IsNullOrWhiteSpace(input) && int.TryParse(input, out int result))
                return null; //SearchTopic(result, list);
            else
                return SearchTopic(input, list);
        }
        
        //public static List<T> SearchTopic<T>(int input, List<T> list)
        //{
        //    return list.Where(topic => topic.Id == input).ToList();
        //}
        public static List<T> SearchTopic<T>(string input, List<T> list)
        {
            List<T> results = new List<T>();

            //return list.Select(topic => topic.GetType().GetProperty("Title")).First().GetValue().ToString();

            for (int i = 0; i < list.Count; i++)
            {
                var kokeilu = list.Select(topic => topic.GetType().GetProperty("Title")).First().GetValue(list[i]).ToString();

                if (Regex.IsMatch(kokeilu, input, RegexOptions.IgnoreCase))
                {
                    results.Add(list[i]);
                }
            }
            return results;
        }
    }
}
