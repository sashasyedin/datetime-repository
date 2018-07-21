using System;

namespace DateTimeRepository.Abstractions
{
    /// <summary>
    /// Provides date and time information.
    /// </summary>
    public interface IDateTimeProvider
    {
        /// <summary>
        /// Gets the current date time.
        /// </summary>
        /// <returns>The current date and time.</returns>
        DateTime GetCurrentDateTime();

        /// <summary>
        /// Gets the date today.
        /// </summary>
        /// <returns>The date today.</returns>
        DateTime GetToday();

        /// <summary>
        /// Gets the todays day of the week.
        /// </summary>
        /// <returns>The day of the week today.</returns>
        DayOfWeek GetTodaysDayOfTheWeek();

        /// <summary>
        /// Gets the time now.
        /// </summary>
        /// <returns>The time now.</returns>
        TimeSpan GetTimeNow();
    }
}
