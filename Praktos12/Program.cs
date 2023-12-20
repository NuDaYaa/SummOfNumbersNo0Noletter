using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        string sumOfDigits = SumDigits(input);
        string result = RemoveZeros(sumOfDigits);

        Console.WriteLine("Результат: " + result);
    }

    static string SumDigits(string input)
    {
        StringBuilder sum = new StringBuilder();
        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                sum.Append(c);
            }
        }

        int total = int.Parse(sum.ToString());
        return total.ToString();
    }

    static string RemoveZeros(string input)
    {
        StringBuilder result = new StringBuilder();
        bool foundNonZero = false;

        foreach (char c in input)
        {
            if (c != '0')
            {
                result.Append(c);
                foundNonZero = true;
            }
            else if (foundNonZero)
            {
                result.Append(c);
            }
        }

        return result.ToString();
    }
}