using Lazar.Extensions;
using System;
using Xunit;

namespace Lazar.Tests
{
    public class ExceptionExtTests
    {
        [Fact]
        public void TestNoInnerException()
        {
            string expected = "testing exceptions";
            string actual;

            try
            {
                throw new DivideByZeroException("testing exceptions");
            }
            catch (Exception ex)
            {
                actual = ex.ExceptionMessages();
            }

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestWithInnerException()
        {
            string expected = $"outer exception{Environment.NewLine}  - InnerException: inner exception";
            string actual;

            try
            {
                Exception inner = new NullReferenceException("inner exception");
                Exception ex = new DivideByZeroException("outer exception", inner);
                throw ex;
            }
            catch (Exception ex)
            {
                actual = ex.ExceptionMessages();
            }

            Assert.Equal(expected, actual);
        }
    }
}