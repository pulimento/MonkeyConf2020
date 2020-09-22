using MyIncredibleApp;
using System;
using Xunit;

namespace MyIncredibleTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var d = new FooClass();
            Assert.True(d.Feature());
        }
    }
}
