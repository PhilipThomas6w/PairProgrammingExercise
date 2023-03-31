namespace MoneyProblemApp;

public class Program
{
    static void Main()
    {
        Console.WriteLine(CurrencyCalculator(7.88M));
    }

    public static string CurrencyCalculator(decimal moneyIn)
    {
        int [] denominations = {200, 100, 50, 20, 10, 5, 2, 1};
        int[] counts = new int[denominations.Length];
        int remainder = (int)(moneyIn * 100);

        for (int i = 0; i < counts.Length; i++)
        {
            while (remainder >= denominations[i])
            {
                counts[i]++;
                remainder -= denominations[i];
            }
        }

        return $"You have {counts[0]} £2 coins, {counts[1]} £1 coins, {counts[2]} 50ps, {counts[3]} 20ps, {counts[4]} 10ps, {counts[5]} 5ps, {counts[6]} 2ps, and {counts[7]} 1ps.";
    }




}