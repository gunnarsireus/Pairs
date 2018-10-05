using Xunit;

namespace XUnitTestPairs
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var p = Pairs.Program.CountNumberOfPairsWithDiff(5, 2, new int[] { 1, 5, 3, 4, 2 });
            Assert.Equal(3, p);
        }
    }
}
