namespace StudentsGrades.DomainObject
{
    using System;
    using System.Collections.Generic;

    public static class Constants
    {
        public static int StartWeek => 35;

        public static Dictionary<Func<int, bool>, decimal> Coeficients =>
            new Dictionary<Func<int, bool>, decimal>
            {
                {weekOfReporting => weekOfReporting == 12, decimal.Zero},
                {weekOfReporting => weekOfReporting == 11, 0.2m},
                {weekOfReporting => weekOfReporting == 10, 0.4m},
                {weekOfReporting => weekOfReporting == 9, 0.6m},
                {weekOfReporting => weekOfReporting == 8, 0.8m},
                {weekOfReporting => weekOfReporting == 7, 1m},
                {weekOfReporting => weekOfReporting == 6, 1.05m},
                {weekOfReporting => weekOfReporting == 5, 1.1m},
                {weekOfReporting => weekOfReporting == 4, 1.15m},
                {weekOfReporting => weekOfReporting <= 3, 1.2m},
            };
    }
}