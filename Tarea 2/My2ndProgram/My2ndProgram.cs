using System;

public class My2ndProgram
{
    public static void Main(string[] args)
    {
        Console.Write("Enter an integer number: ");
        int number = int.Parse(Console.ReadLine()!);

        if (number % 2 == 0)
        {
            // If the remainder of the division by 2 is 0, this condition is met and the number is even
            Console.WriteLine($"The number {number} is even");
        }
        else
        {
            // If the remainder of the division by 2 is not 0, this condition is met and the number is odd
            Console.WriteLine($"The number {number} is odd");
        }
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey(true);
    }
}