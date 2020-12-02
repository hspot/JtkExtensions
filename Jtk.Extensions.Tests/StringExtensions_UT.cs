using Xunit;

namespace Jtk.Extensions.Tests
{
    public class StringExtensions_UT
    {
        [Fact]
        public void NullSafe_Handle_String_With_Value()
        {
            var stringLength = "myString".NullSafe().Length;

            Assert.Equal(8, stringLength);
        }

        [Fact]
        public void NullSafe_Handle_Null_String()
        {
            string myString = null;
            var stringLength = myString.NullSafe(m => m.Length);

            Assert.Equal(0, stringLength);
        }

        [Theory]
        [InlineData("", true)]        
        [InlineData(null, true)]
        [InlineData(" ", false)]
        [InlineData("Blah", false)]
        public void IsNullOrEmpty_Tests(string inputString, bool expectedResult)
        {
            var result = inputString.IsNullOrEmpty();

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("", false)]
        [InlineData(null, false)]
        [InlineData(" ", true)]
        [InlineData("Blah", true)]
        public void IsNotNullOrEmpty_Tests(string inputString, bool expectedResult)
        {
            var result = inputString.IsNotNullOrEmpty();

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(" ", true)]
        [InlineData(null, true)]
        [InlineData("", true)]
        [InlineData("Blah", false)]
        public void IsNullOrWhiteSpace_Tests(string inputString, bool expectedResult)
        {
            var result = inputString.IsNullOrWhiteSpace();

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(" ", false)]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData("Blah", true)]
        public void IsNotNullOrWhiteSpace_Tests(string inputString, bool expectedResult)
        {
            var result = inputString.IsNotNullOrWhiteSpace();

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("", null)]
        [InlineData("fjd", null)]
        [InlineData("12fj", null)]
        [InlineData("123", 123)]
        public void TryParse_ParseIntStrings(string input, int? expectedOutput)
        {
            var result = input.TryParse();

            Assert.Equal(expectedOutput, result);
        }
    }
}
