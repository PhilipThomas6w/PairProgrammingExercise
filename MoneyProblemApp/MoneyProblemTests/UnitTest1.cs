using MoneyProblemApp;

namespace MoneyProblemTests
{
    public class Tests
    {
        [TestCase(7.88, "You have 3 £2 coins, 1 £1 coins, 1 50ps, 1 20ps, 1 10ps, 1 5ps, 1 2ps, and 1 1ps.")]
        [TestCase(0, "You have 0 £2 coins, 0 £1 coins, 0 50ps, 0 20ps, 0 10ps, 0 5ps, 0 2ps, and 0 1ps.")]
        [TestCase(43.27, "You have 21 £2 coins, 1 £1 coins, 0 50ps, 1 20ps, 0 10ps, 1 5ps, 1 2ps, and 0 1ps.")]
        public void Test1(decimal moneyIn, string expectedResult)
        {
            Assert.That(Program.CurrencyCalculator(moneyIn), Is.EqualTo(expectedResult));
        }
    }
}