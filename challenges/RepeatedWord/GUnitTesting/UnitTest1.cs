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
            string sent = "Battle beet bear battle star galactica";

            string result = Program.RepeatedWord(sent);

            Assert.Equal("battle", result);

        }

        [Fact]
        public void TestAgainWithSpecialChar()
        {
            string sent = "Battle, beet bear battle star galactica";

            string result = Program.RepeatedWord(sent);

            Assert.Equal("battle", result);

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
