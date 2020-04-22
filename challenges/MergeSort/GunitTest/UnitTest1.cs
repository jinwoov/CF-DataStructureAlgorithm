using MergeSort;
using System;
using Xunit;

namespace GunitTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanSuccessfullySort()
        {
            int[] before = { 7, 6, 3, 4, 2, 1 };

            Program.MergeSort(before);

            int[] expect = { 1, 2, 3, 4, 6, 7 };

            Assert.Equal(expect, before);

        }

        [Fact]
        public void ExpectToFail()
        {
            int[] before = { 7, 6, 3, 4, 2, 1 };

            Program.MergeSort(before);

            int[] test = { 7, 6, 3, 4, 2, 1 };

            Assert.NotEqual(test, before);
        }

        [Fact]
        public void EdgeCase()
        {
            int[] before = { 0, 0, 0, 0, 0 };

            Program.MergeSort(before);

            int[] expect = { 0, 0, 0, 0, 0 };

            Assert.Equal(expect, before);
        }
    }
}
