using System;

namespace DateTimeRepository.Utilities
{
    public static class DateTimeHelpers
    {
        public static DateTime CalculateWorkingDaysFromInputDate(DateTime startDate, int workingDays)
        {
            if (startDate.DayOfWeek == DayOfWeek.Saturday
                || startDate.DayOfWeek == DayOfWeek.Sunday)
            {
                workingDays -= 1;
            }

            for (var index = 1; index <= workingDays; index++)
            {
                switch (startDate.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        startDate = startDate.AddDays(2);
                        break;
                    case DayOfWeek.Monday:
                    case DayOfWeek.Tuesday:
                    case DayOfWeek.Wednesday:
                    case DayOfWeek.Thursday:
                    case DayOfWeek.Friday:
                        startDate = startDate.AddDays(1);
                        break;
                    case DayOfWeek.Saturday:
                        startDate = startDate.AddDays(3);
                        break;
                }
            }

            if (startDate.DayOfWeek == DayOfWeek.Saturday)
            {
                startDate = startDate.AddDays(2);
            }
            else if (startDate.DayOfWeek == DayOfWeek.Sunday)
            {
                startDate = startDate.AddDays(1);
            }

            return startDate;
        }
    }
}
