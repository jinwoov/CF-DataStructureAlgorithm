using System;
using Xunit;
using ArrayShift;

namespace shitArrayTesting
{
    public class UnitTest1
    {
        // testing inserting a value to middle
        [Fact]
        public void InsertIntoArrayTest()
        {
            int[] testArray = new[] {2, 4, 6, 8};
            int[] resultArray = new[] {2, 4, 5, 6, 8};
            Assert.Equal(resultArray, Program.InsertShiftArray(testArray, 5));
        }

        [Fact]
        public void InsertIntoArrayTest1()
        {
            int[] testArray = new[] { 4, 8, 15, 23, 42 };
            int[] resultArray = new[] { 4, 8, 15, 16, 23, 42 };
            Assert.Equal(resultArray, Program.InsertShiftArray(testArray, 16));
        }

        //testing deleting middle elements
        [Fact]
        public void DeletingMiddleElement()
        {
            int[] testArray = new[] { 4, 8, 15, 23, 42 };
            int[] resultArray = new[] { 4, 8, 23, 42 };
            Assert.Equal(resultArray, Program.StretchGoal(testArray));
        }
        [Fact]
        public void DeletingMiddleElement1()
        {
            int[] testArray = new[] { 2, 4, 6, 8 };
            int[] resultArray = new[] { 2, 4, 8 };
            Assert.Equal(resultArray, Program.StretchGoal(testArray));
        }
    }
}
