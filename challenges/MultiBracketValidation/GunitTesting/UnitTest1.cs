using System;
using Xunit;
using MultiBracketValidation;

namespace GunitTesting
{
    public class UnitTest1
    {
        [Fact]
        public void TestEmptyStringWillGiveFalse()
        {
            bool result = Program.MultiBracketValidation("");

            Assert.False(result);
        }
        [Fact]
        public void MissingAPhrenOutputsFalse()
        {
            bool result = Program.MultiBracketValidation("[({}]");

            Assert.False(result);
        }
        [Fact]
        public void HavingSingleBracketIsFalse()
        {
            bool result = Program.MultiBracketValidation("[");

            Assert.False(result);
        }
        [Fact]
        public void TestComesOutPassIfAllOfTheBracketIsPresent()
        {
            bool result = Program.MultiBracketValidation("{}{Code}[Fellows](())");

            Assert.True(result);
        }
        [Fact]
        public void HappyTrail()
        {
            bool result = Program.MultiBracketValidation("()[[Extra Characters]]");

            Assert.True(result);
        }
    }
}
