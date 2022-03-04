using System;
using Xunit;

namespace DemoPublisherAPI.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string expected = "hello";
            string actual = "hello";
            Assert.Equal(expected, actual);
        }
    }
}
