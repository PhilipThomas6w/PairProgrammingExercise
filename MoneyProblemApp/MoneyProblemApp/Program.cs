namespace MoneyProblemApp;

public class Program
{
    static void Main()
    {
        
    }

    public static int[] CurrencyCalculator(decimal moneyIn)
    {
        int [] denominations = {200, 100, 50, 20, 10, 5, 2, 1};
        int[] counts = new int[8];
        int remainder = (int)(moneyIn * 100);

        for(int i = 0; i < 8; i++)
        {
            counts[i] = remainder / denominations[i];
        }

        return counts;
    }




}