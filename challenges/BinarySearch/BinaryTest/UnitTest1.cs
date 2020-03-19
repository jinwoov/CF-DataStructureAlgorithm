using System;
using Xunit;
using BinarySearch;

namespace BinaryTest
{
    public class UnitTest1
    {
        // this test is checking to see if there is matching element to the given value, it will return index position.
        [Fact]
        public void ArraySearch()
        {
            int[] array = { 4, 8, 15, 16, 23, 42 };
            Assert.Equal(2, Program.BinarySearch(array, 15));
        }
        // This is testing when value isn't in the array, it will spit out -1
        [Fact]
        public void ArraySearchWhenNoneAvailable()
        {
            int[] array = { 4, 8, 15, 16, 23, 42 };

            Assert.Equal(-1, Program.BinarySearch(array, 90));

        }
    }
}
