using DateTimeRepository.Abstractions;
using DateTimeRepository.Utilities;
using System;

namespace DateTimeRepository
{
    /// <summary>
    /// Supplies date and time information.
    /// </summary>
    public sealed class DateTimeRepository : IDateTimeRepository
    {
        /// <summary>
        /// Gets the current date time.
        /// </summary>
        /// <returns>The current date and time.</returns>
        DateTime IDateTimeRepository.GetCurrentDateTime()
        {
            return DependencyProvider.GetCurrentDateTime();
        }

        /// <summary>
        /// Gets the date today.
        /// </summary>
        /// <returns>The date today.</returns>
        DateTime IDateTimeRepository.GetToday()
        {
            return DependencyProvider.GetToday();
        }

        /// <summary>
        /// Gets the todays day of the week.
        /// </summary>
        /// <returns>The day of the week today.</returns>
        DayOfWeek IDateTimeRepository.GetTodaysDayOfTheWeek()
        {
            return DependencyProvider.GetTodaysDayOfTheWeek();
        }

        /// <summary>
        /// Gets the time now.
        /// </summary>
        /// <returns>The time now.</returns>
        TimeSpan IDateTimeRepository.GetTimeNow()
        {
            return DependencyProvider.GetTimeNow();
        }

        /// <summary>
        /// Gets the date in X working days.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="workingDays">The working days (can be negative to deduct working days).</param>
        /// <returns>
        /// The date in x working days.
        /// </returns>
        DateTime? IDateTimeRepository.GetDateInXWorkingDays(DateTime startDate, int workingDays)
        {
            if (workingDays == 0)
            {
                // No working days to add
                return startDate;
            }
            else
            {
                // Need to add or subtract working days
                if (workingDays > 0)
                {
                    // Need to add working days
                    return DateTimeHelpers.CalculateWorkingDaysFromInputDate(startDate, workingDays);
                }
                else
                {
                    // Need to subtract working days
                    throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets the date in X working days from the current date.
        /// </summary>
        /// <param name="workingDays">The working days (can be negative to deduct working days).</param>
        /// <returns>The date in x working days.</returns>
        DateTime? IDateTimeRepository.GetDateInXWorkingDaysFromCurrentDateTime(int workingDays)
        {
            IDateTimeRepository dateTimeRepository = this;
            return dateTimeRepository.GetDateInXWorkingDays(dateTimeRepository.GetCurrentDateTime(), workingDays);
        }

        /// <summary>
        /// Gets the date in X working days from the current date.
        /// </summary>
        /// <param name="workingDays">The working days (can be negative to deduct working days).</param>
        /// <returns>The date in x working days.</returns>
        DateTime? IDateTimeRepository.GetDateInXWorkingDaysFromCurrentDate(int workingDays)
        {
            IDateTimeRepository dateTimeRepository = this;
            return dateTimeRepository.GetDateInXWorkingDays(dateTimeRepository.GetCurrentDateTime().Date, workingDays);
        }
    }
}
