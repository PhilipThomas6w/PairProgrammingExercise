using MoneyProblemApp;

namespace MoneyProblemTests
{
    public class Tests
    {
        [TestCase(7.58, "3 two-pounds, 1 1-pounds, 2 20-pence, 1 10-pence, 1 5-pence, 1 2-pence, 1 1-pence")]
        
        public void Test1(decimal moneyIn, int[] expectedResult)
        {
            Assert.That(Program.CurrencyCalculator(moneyIn), Is.EqualTo(expectedResult));
        }
    }
}