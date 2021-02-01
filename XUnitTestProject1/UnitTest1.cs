using System;
using Xunit;
using Inlämningsuppgift;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(5, ConvertToNumber.TextConverter("five"));
        }
    }
}
