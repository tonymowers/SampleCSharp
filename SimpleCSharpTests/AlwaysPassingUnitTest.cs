using static SimpleCSharpProject.OperationUtils;
using Xunit;

namespace SimpleCSharpTests
{
    public class AlwaysPassingUnitTest
    {
        [Fact]
        public void AlwaysPassesTest()
        {
            Assert.True(true, "Test will always pass");
        }
        
        [Fact]
        public void SimpleOperationTest()
        {
            Assert.True(OperationAlwaysReturnsTrue(), "Test will always pass");
        }
    }
}