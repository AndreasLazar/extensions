using Extensions;
using System;
using Xunit;

namespace Tests
{
    public class DateTimeExtTests
    {
        [Fact]
        public void TestDateTimeBetweenTrue()
        {
            DateTime dateTime = new DateTime(2018, 2, 8, 13, 35, 0);
            DateTime start = new DateTime(2018, 2, 7, 13, 35, 0);
            DateTime end = new DateTime(2018, 2, 9, 13, 35, 0);

            Assert.True(dateTime.Between(start, end));
        }

        [Fact]
        public void TestDateTimeBetweenFalse()
        {
            DateTime dateTime = new DateTime(2018, 2, 26, 13, 35, 0);
            DateTime start = new DateTime(2018, 2, 7, 13, 35, 0);
            DateTime end = new DateTime(2018, 2, 9, 13, 35, 0);

            Assert.False(dateTime.Between(start, end));
        }
        
        [Fact]
        public void TestDateTimeBetweenExactStart()
        {
            DateTime dateTime = new DateTime(2018, 2, 8, 13, 35, 0);
            DateTime start = new DateTime(2018, 2, 8, 13, 35, 0);
            DateTime end = new DateTime(2018, 2, 9, 13, 35, 0);

            Assert.True(dateTime.Between(start, end));
        }
        
        [Fact]
        public void TestDateTimeBetweenExactEnd()
        {
            DateTime dateTime = new DateTime(2018, 2, 8, 13, 35, 0);
            DateTime start = new DateTime(2018, 2, 8, 13, 35, 0);
            DateTime end = new DateTime(2018, 2, 8, 13, 35, 0);

            Assert.True(dateTime.Between(start, end));
        }
        
        [Fact]
        public void TestDateTimeIsWeekend()
        {
            DateTime monday = new DateTime(2018, 2, 5, 13, 35, 0);
            DateTime tuesday = new DateTime(2018, 2, 6, 13, 35, 0);
            DateTime wednesday = new DateTime(2018, 2, 7, 13, 35, 0);
            DateTime thursday = new DateTime(2018, 2, 8, 13, 35, 0);
            DateTime friday = new DateTime(2018, 2, 9, 13, 35, 0);
            DateTime saturday = new DateTime(2018, 2, 10, 13, 35, 0);
            DateTime sunday = new DateTime(2018, 2, 11, 13, 35, 0);

            Assert.False(monday.IsWeekend(), "monday");
            Assert.False(tuesday.IsWeekend(), "tuesday");
            Assert.False(wednesday.IsWeekend(), "wednesday");
            Assert.False(thursday.IsWeekend(), "thursday");
            Assert.False(friday.IsWeekend(), "friday");
            Assert.True(saturday.IsWeekend(), "saturday");
            Assert.True(sunday.IsWeekend(), "sunday");
        }
        
        [Fact]
        public void TestDateTimeIsWeekday()
        {
            DateTime monday = new DateTime(2018, 2, 5, 13, 35, 0);
            DateTime tuesday = new DateTime(2018, 2, 6, 13, 35, 0);
            DateTime wednesday = new DateTime(2018, 2, 7, 13, 35, 0);
            DateTime thursday = new DateTime(2018, 2, 8, 13, 35, 0);
            DateTime friday = new DateTime(2018, 2, 9, 13, 35, 0);
            DateTime saturday = new DateTime(2018, 2, 10, 13, 35, 0);
            DateTime sunday = new DateTime(2018, 2, 11, 13, 35, 0);

            Assert.True(monday.IsWeekday(), "monday");
            Assert.True(tuesday.IsWeekday(), "tuesday");
            Assert.True(wednesday.IsWeekday(), "wednesday");
            Assert.True(thursday.IsWeekday(), "thursday");
            Assert.True(friday.IsWeekday(), "friday");
            Assert.False(saturday.IsWeekday(), "saturday");
            Assert.False(sunday.IsWeekday(), "sunday");
        }
    }
}