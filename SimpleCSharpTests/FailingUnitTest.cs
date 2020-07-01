using Xunit;

namespace SimpleCSharpTests
{
    public class FailingUnitTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(false, "Test not yet implemented");
        }
    }
}