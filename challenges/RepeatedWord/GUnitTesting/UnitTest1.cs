using RepeatedWord;
using System;
using Xunit;

namespace GUnitTesting
{
    public class UnitTest1
    {
        [Fact]
        public void TestMyMehodIsCheckingForDuplicate()
        {
            string sent = "glowing blue pro blue dool";

            string result = Program.RepeatedWord(sent);

            Assert.Equal("blue", result);

        }

        [Fact]
        public void TestAgainWithSpecialChar()
        {
            string sent = "focus hocus rocus locus hocus";

            string result = Program.RepeatedWord(sent);

            Assert.Equal("hocus", result);

        }

        [Fact]
        public void CheckingToSeeIfitwillPassWithOtherWord()
        {
            string sent = "Sea, shell, she shell";

            string result = Program.RepeatedWord(sent);

            Assert.Equal("shell", result);

        }
    }
}
