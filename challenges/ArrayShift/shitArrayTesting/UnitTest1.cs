using System;
using Xunit;
using ArrayShift;

namespace shitArrayTesting
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] testArray = new[] {2, 4, 6, 8};
            int[] resultArray = new[] {2, 4, 5, 6, 8};
            Assert.Equal(resultArray, Program.InsertShiftArray(testArray, 5));
        }

        [Fact]
        public void Test2()
        {
            int[] testArray = new[] { 4, 8, 15, 23, 42 };
            int[] resultArray = new[] { 4, 8, 15, 16, 23, 42 };
            Assert.Equal(resultArray, Program.InsertShiftArray(testArray, 16));
        }
    }
}
