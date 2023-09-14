using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, and type 0 when finish: ");

        int inputNumber = -2;

        while (inputNumber != 0)
        {
            Console.Write("Enter number: ");
            inputNumber = int.Parse(Console.ReadLine());
            
            // Add number to the list if it is not zero
            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }
            Console.WriteLine(numbers);
        }

        // Compute the total of numbers in the list.
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");
        

        // Compute the average of numbers in the list.
        float average =  ((float) sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Compute the largest number.
        int largest = numbers[0];

        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
    }
}