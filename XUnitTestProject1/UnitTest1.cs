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
            Piano piano = new Piano();

            piano.KeyboardSetup();

            piano.RightArrow();

            Assert.Equal(1, piano.index);
        }
        
    }
}
