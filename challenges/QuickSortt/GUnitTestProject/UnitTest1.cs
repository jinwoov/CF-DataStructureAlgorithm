using QuickSortt;
using System;
using Xunit;

namespace GUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void CheckToSeeIfMyLogicWorks()
        {
            int[] test = { 8, 4, 23, 42, 16, 15 };

            int length = test.Length - 1;

            Program.QuickSort(test, 0, length);

            int[] expected = { 4, 8, 15, 16, 23, 42 };

            Assert.Equal(expected, test);
        }

        [Fact]
        public void ExpectThisToNotEqual()
        {
            int[] test = { 8, 4, 23, 42, 16, 15 };

            int length = test.Length - 1;

            Program.QuickSort(test, 0, length);

            int[] expected = { 8, 4, 23, 42, 16, 15 };

            Assert.NotEqual(expected, test);
        }

        [Fact]
        public void EdgeCase()
        {
            int[] test = { 0, 0, 0, 0, 0, 0 };

            int length = test.Length - 1;

            Program.QuickSort(test, 0, length);

            int[] expected = { 0, 0, 0, 0, 0, 0 };

            Assert.Equal(expected, test);
        }
    }
}
