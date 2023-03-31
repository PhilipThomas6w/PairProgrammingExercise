using MoneyProblemApp;

namespace MoneyProblemTests
{
    public class Tests
    {
        [TestCase(7.88, "You have 3 £2 coins, 1 £1 coins, 1 50ps, 1 20ps, 1 10ps, 1 5ps, 1 2ps, and 1 1ps.")]
        
        public void Test1(decimal moneyIn, string expectedResult)
        {
            Assert.That(Program.CurrencyCalculator(moneyIn), Is.EqualTo(expectedResult));
        }
    }
}