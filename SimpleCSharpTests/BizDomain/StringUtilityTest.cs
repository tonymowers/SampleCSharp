using Xunit;
using static SimpleCSharpProject.BizDomain.StringUtility;

namespace SimpleCSharpTests.BizDomain
{
    public class StringUtilityTest
    {

        [Fact]
        public void convert_first_letter_of_sentence_to_upper()
        {
            Assert.Equal("H",FirstLetterOfSentenceToUpper("h"));
            Assert.Equal("Hello",FirstLetterOfSentenceToUpper("hello"));
            Assert.Equal("",FirstLetterOfSentenceToUpper(""));
            Assert.Null(FirstLetterOfSentenceToUpper(null));

            Assert.Equal(" Hello", FirstLetterOfSentenceToUpper(" hello"));
            Assert.Equal(" Hello. Hello.", FirstLetterOfSentenceToUpper(" hello. hello."));
            Assert.Equal(" Hello? Hello.", FirstLetterOfSentenceToUpper(" hello? hello."));
        }
        
    }
}