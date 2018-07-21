using DateTimeRepository.Abstractions;
using System;

namespace DateTimeRepository
{
    /// <summary>
    /// Provides date and time related values.
    /// </summary>
    public sealed class DateTimeProvider : IDateTimeProvider
    {
        /// <summary>
        /// Gets the current date time.
        /// </summary>
        /// <returns>The current date and time.</returns>
        DateTime IDateTimeProvider.GetCurrentDateTime()
        {
            return DateTime.Now;
        }

        /// <summary>
        /// Gets the date today.
        /// </summary>
        /// <returns>The date today.</returns>
        DateTime IDateTimeProvider.GetToday()
        {
            return DateTime.Today;
        }

        /// <summary>
        /// Gets the todays day of the week.
        /// </summary>
        /// <returns>The day of the week today.</returns>
        DayOfWeek IDateTimeProvider.GetTodaysDayOfTheWeek()
        {
            return DateTime.Today.DayOfWeek;
        }

        /// <summary>
        /// Gets the time now.
        /// </summary>
        /// <returns>The time now.</returns>
        TimeSpan IDateTimeProvider.GetTimeNow()
        {
            return DateTime.Now.TimeOfDay;
        }
    }
}
