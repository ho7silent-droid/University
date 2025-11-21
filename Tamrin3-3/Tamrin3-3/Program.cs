using System;
class Program
{
    static void Main()
    {
        int number;
        int result = 1;

        Console.WriteLine("Enter number(for end Enter 0):");

        while (true)
        {
            number =
                int.Parse(Console.ReadLine());

            if (number == 0)
                break;

            result = result * number;
        }
        Console.WriteLine("Multiplication =v" + result);
        }
    }
