namespace StudentsGrades
{
    using System;
    using System.Globalization;
    using System.Linq;
    using DomainObject;

    public static class GradesAgent
    {
        public static string GetGrade(decimal grade, DateTime dateOfReporting)
        {
            var weekOfTheYear = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(dateOfReporting,
                CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            var gradeCoeficient = GetGradeCoefficient(weekOfTheYear - Constants.StartWeek);
            var finalGrade = (grade / 10) * gradeCoeficient;
            return finalGrade.ToString(CultureInfo.InvariantCulture);
        }

        public static decimal GetGradeCoefficient(int weekOfReporting)
        {
            return Constants.Coeficients.First(coef => coef.Key(weekOfReporting)).Value; 
        }
    }
}