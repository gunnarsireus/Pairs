using Xunit;

namespace XUnitTestPairs
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] intArr = new int[100000];
            for (int i = 0; i < 100000; i++)
            {
                intArr[i] = 1 + i*3;
            }
            var p = Pairs.Program.CountNumberOfPairsWithDiff(intArr.Length, 3, intArr);
            Assert.Equal(99999, p);
        }
    }
}
