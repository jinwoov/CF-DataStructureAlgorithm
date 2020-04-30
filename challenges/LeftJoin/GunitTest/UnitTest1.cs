using LeftJoin;
using LeftJoin.Class;
using System;
using Xunit;

namespace GunitTest
{
    public class UnitTest1
    {
        [Fact]
        public void AbleToAddToHashTableOne()
        {
            Hashtable ht = new Hashtable(10);
            ht.Add("Water", "Moisture");

            Hashtable htTwo = new Hashtable(10);
            htTwo.Add("Water", "Dry");

            Hashtable result = Program.LeftJoins(ht, htTwo);

            string value = result.Get("Water");

            Assert.Equal("Dry", value);
        }

        [Fact]
        public void AbleToGetNullWhenSecondTableDoesnotHaveKey()
        {
            Hashtable ht = new Hashtable(10);
            ht.Add("Water", "Moisture");

            Hashtable htTwo = new Hashtable(10);
            htTwo.Add("Sleepy", "Awake");

            Hashtable result = Program.LeftJoins(ht, htTwo);

            string value = result.Get("Water");

            Assert.Equal("Null", value);
        }

        [Fact]
        public void AbleToMergeMultipleKeyValues()
        {
            Hashtable ht = new Hashtable(10);
            ht.Add("Water", "Moisture");
            ht.Add("Sleepy", "Nappy");
            ht.Add("Ice", "Snow");

            Hashtable htTwo = new Hashtable(10);
            htTwo.Add("Water", "Dry");
            htTwo.Add("Sleepy", "Awake");
            htTwo.Add("Ice", "Water");

            Hashtable result = Program.LeftJoins(ht, htTwo);

            int hasedNum = result.Hash("Water");

            int lengthOfLinkedList = result.Table[hasedNum].Count;

            Assert.Equal(2, lengthOfLinkedList);
        }
    }
}
