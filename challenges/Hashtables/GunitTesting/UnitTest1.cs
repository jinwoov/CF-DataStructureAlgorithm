using Hashtables.Class;
using System;
using Xunit;

namespace GunitTesting
{
    public class UnitTest1
    {
        [Fact]
        public void AddingKeyAndValueReturnsValue()
        {
            Hashtable hs = new Hashtable(50);
            hs.Add("Dog", "Mochi");

            bool result = hs.Contains("Dog");

            Assert.True(result);
        }

        [Fact]
        public void GettingValueUsingKey()
        {
            Hashtable hs = new Hashtable(50);
            hs.Add("Dog", "Mochi");

            string result = hs.Get("Dog");

            Assert.Equal("Mochi", result);
        }

        [Fact]
        public void ReturnNullWhenItDoesNotExist()
        {
            Hashtable hs = new Hashtable(50);

            Assert.Null(hs.Get("Dog"));

        }

        [Fact]
        public void AvoidCollision()
        {
            Hashtable hs = new Hashtable(50);
            hs.Add("Dog", "Mochi");
            hs.Add("Dog", "Rochi");

            string result = hs.Get("Dog");

            Assert.Equal("Rochi", result);
        }

        [Fact]
        public void CanSuccessfullyGetValueFromCollision()
        {
            Hashtable hs = new Hashtable(50);
            hs.Add("Dog", "Mochi");
            hs.Add("Dog", "Rochi");

            string result = hs.Get("Dog");

            Assert.Equal("Rochi", result);
        }

        [Fact]
        public void CanHashToInRangeValue()
        {
            Hashtable hs = new Hashtable(50);
            int position = hs.Hash("dog");

            Assert.InRange(position, 0, 50);
        }
    }
}
