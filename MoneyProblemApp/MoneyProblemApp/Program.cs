namespace MoneyProblemApp;

public class Program
{
    static void Main()
    {
        Console.WriteLine(RomanNumeralsConverter(2023));
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


    public static string RomanNumeralsConverter(int inputNum)
    {
        if(inputNum > 3999 || inputNum < 1)
        {
            throw new ArgumentException("This value cannot be represented in Roman numerals.");
        }
        string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] thousands = { "", "M", "MM", "MMM" };
        int remainder = inputNum;
        int[] placeValue = new int[4];
        placeValue[3] = remainder / 1000;
        remainder -= 1000 * placeValue[3];
        placeValue[2] = remainder / 100;
        remainder -= 100 * placeValue[2];
        placeValue[1] = remainder / 10;
        remainder -= 10 * placeValue[1];
        placeValue[0] = remainder;

        string processedNumeral = $"The Roman numeral is {thousands[placeValue[3]]}{hundreds[placeValue[2]]}{tens[placeValue[1]]}{ones[placeValue[0]]}";
        return processedNumeral;
    }

    //int[] numeralValues = { 1000, 500, 100, 50, 10, 5, 1 };
    //int[] counts = new int[numeralValues.Length];
    //int remainder = inputNum;
    //for (int i = 0; i < counts.Length; i++)
    //{
    //    while (remainder >= numeralValues[i])
    //    {
    //        counts[i]++;
    //        remainder -= numeralValues[i];
    //    }
    //}

    ////for(int i = 6; i >= 0; i--)
    ////{
    ////    if (counts[i] == numeralValues[i] - 1)
    ////    {

    ////    }
    ////}

}