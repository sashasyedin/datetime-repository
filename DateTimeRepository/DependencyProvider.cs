using DateTimeRepository.Abstractions;
using System;

namespace DateTimeRepository
{
    /// <summary>
    /// Provides access to injected repositories.
    /// </summary>
    public static class DependencyProvider
    {
        /// <summary>
        /// Provides access to date and time related values.
        /// </summary>
        private static IDateTimeProvider _dateTimeProvider;

        /// <summary>
        /// Configures the date and time repository dependency.
        /// </summary>
        /// <param name="dateAndTimeProvider">The concrete date and time repository to use.</param>
        public static void ConfigureDependency(IDateTimeProvider dateAndTimeProvider)
        {
            _dateTimeProvider = dateAndTimeProvider ?? throw new ArgumentNullException(nameof(dateAndTimeProvider));
        }

        /// <summary>
        /// Gets the current date time.
        /// </summary>
        /// <returns>The current date time.</returns>
        public static DateTime GetCurrentDateTime()
        {
            return _dateTimeProvider.GetCurrentDateTime();
        }

        /// <summary>
        /// Gets the current time.
        /// </summary>
        /// <returns>The current time.</returns>
        public static TimeSpan GetTimeNow()
        {
            return _dateTimeProvider.GetTimeNow();
        }

        /// <summary>
        /// Gets the current day.
        /// </summary>
        /// <returns>The current day.</returns>
        public static DateTime GetToday()
        {
            return _dateTimeProvider.GetToday();
        }

        /// <summary>
        /// Gets the current day of the week.
        /// </summary>
        /// <returns>The current day of the week.</returns>
        public static DayOfWeek GetTodaysDayOfTheWeek()
        {
            return _dateTimeProvider.GetTodaysDayOfTheWeek();
        }
    }
}
