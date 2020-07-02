using static SimpleCSharpProject.Domain.MathUtility;
using Xunit;

namespace SimpleCSharpTests
{
    public class SampleUnitTests
    {
        [Fact]
        public void true_is_always_true()
        {
            Assert.True(true, "Test will always pass");
        }
        
        [Fact]
        public void numbers_checked_if_even()
        {
            Assert.True(IsEven(2));
            Assert.False(IsEven(3));
        }
    }
}