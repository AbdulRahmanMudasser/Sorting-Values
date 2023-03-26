using System;

public class SortingValues
{
    public static void Main(string[] args)
    {
        int firstNumber;
        int secondNumber;
        int thirdNumber;

        // prompting user and taking first number as input
        Console.Write("Enter First Value:  ");
        firstNumber = Convert.ToInt32(Console.ReadLine());

        // prompting user and taking second number as input
        Console.Write("Enter Second Value:  ");
        secondNumber = Convert.ToInt32(Console.ReadLine());

        // prompting user and taking third number input
        Console.Write("Enter Third Value:  ");
        thirdNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();    // just for spacing purpose

        // to get largest value of three values we are using inbuilt math max method
        Console.WriteLine("Largest Number:  " + Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber)));

        // to get smallest value of three values we are using inbuilt math min method
        Console.WriteLine("Smallest Number:  " + Math.Min(firstNumber, Math.Min(secondNumber, thirdNumber)));
    }
}
