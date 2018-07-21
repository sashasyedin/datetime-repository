using DateTimeRepository.Abstractions;
using DateTimeRepository.Example.Services;
using Moq;
using System;
using Xunit;

namespace DateTimeRepository.Example.Tests.ServicesTests
{
    public class PointlessServiceTests
    {
        private readonly Mock<IDateTimeRepository> _dateTimeRepository;

        private readonly IPointlessService _pointlessService;
        
        private DateTime _currentDateTime;

        private DateTime _nextDate;

        public PointlessServiceTests()
        {
            _dateTimeRepository = new Mock<IDateTimeRepository>();
            _pointlessService = new PointlessService(_dateTimeRepository.Object);
        }

        [Fact]
        public void PointlessMethod_WhenYearIsGreaterThan1999_ExpectMinDateTime()
        {
            _currentDateTime = new DateTime(2000, 1, 1);
            Stub();

            var actual = _pointlessService.PointlessMethod(2);

            Assert.Equal(DateTime.MinValue, actual);
        }

        [Fact]
        public void PointlessMethod_UnderValidCircumstances_ExpectSuccess()
        {
            _currentDateTime = new DateTime(1999, 12, 31, 23, 59, 59);
            _nextDate = new DateTime(2000, 1, 4);
            Stub();

            var actual = _pointlessService.PointlessMethod(2);

            Assert.Equal(new DateTime(2001, 1, 4), actual);
        }

        private void Stub()
        {
            _dateTimeRepository
                .Setup(repository => repository.GetCurrentDateTime())
                .Returns(_currentDateTime);

            _dateTimeRepository
                .Setup(repository => repository.GetDateInXWorkingDaysFromCurrentDate(It.IsAny<int>()))
                .Returns(_nextDate);
        }
    }
}
