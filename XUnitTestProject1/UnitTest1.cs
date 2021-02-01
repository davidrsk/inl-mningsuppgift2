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
            C4 c4 = new C4();
            c4.PlayNote();
            Console.Beep(261, 400);
            
            //Assert.(C4.PlayNote());
        }
    }
}
