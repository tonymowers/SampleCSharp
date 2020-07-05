using Xunit;
using static SimpleCSharpProject.BizDomain.StringUtility;

namespace SimpleCSharpTests.BizDomain
{
    public class StringUtilityTest
    {
        [Theory]
        [InlineData("H","h")]
        [InlineData("Hello","hello")]
        [InlineData("","")]
        [InlineData(" Hello", " hello")]
        [InlineData(" Hello. Hello.", " hello. hello.")]
        [InlineData(" Hello? Hello.", " hello? hello.")]
        public void convert_first_letter_of_sentence_to_upper(string expected, string data)
        {
            Assert.Equal(expected,FirstLetterOfSentenceToUpper(data));
        }
        
    }
}