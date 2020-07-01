using Xunit;

namespace SimpleCSharpTests
{
    public class AlwaysPassingUnitTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true, "Test will always pass");
        }
    }
}