using System;

namespace DateTimeRepository.Abstractions
{
    /// <summary>
    /// Supplies date and time information.
    /// </summary>
    public interface IDateTimeRepository
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

        /// <summary>
        /// Gets the date in X working days.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="workingDays">The working days (can be negative to deduct working days).</param>
        /// <returns>
        /// The date in x working days.
        /// </returns>
        DateTime? GetDateInXWorkingDays(DateTime startDate, int workingDays);

        /// <summary>
        /// Gets the date in X working days from the current date.
        /// </summary>
        /// <param name="workingDays">The working days (can be negative to deduct working days).</param>
        /// <returns>
        /// The date and time in x working days.
        /// </returns>
        DateTime? GetDateInXWorkingDaysFromCurrentDateTime(int workingDays);

        /// <summary>
        /// Gets the date in X working days from the current date.
        /// </summary>
        /// <param name="workingDays">The working days (can be negative to deduct working days).</param>
        /// <returns>
        /// The date in x working days.
        /// </returns>
        DateTime? GetDateInXWorkingDaysFromCurrentDate(int workingDays);
    }
}
