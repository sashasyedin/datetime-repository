using DateTimeRepository.Abstractions;
using System;

namespace DateTimeRepository.Example.Services
{
    public class PointlessService : IPointlessService
    {
        private readonly IDateTimeRepository _dateTimeRepository;

        public PointlessService(IDateTimeRepository dateTimeRepository)
        {
            _dateTimeRepository = dateTimeRepository;
        }

        DateTime IPointlessService.PointlessMethod(int value)
        {
            var minDate = DateTime.MinValue;
            var currentDate = _dateTimeRepository.GetCurrentDateTime();

            if (currentDate.Year > 1999)
            {
                return minDate;
            }

            var anotherDate = _dateTimeRepository.GetDateInXWorkingDaysFromCurrentDate(value);

            if (anotherDate.HasValue == false)
            {
                return minDate;
            }

            return anotherDate.Value.AddYears(1);
        }
    }
}
