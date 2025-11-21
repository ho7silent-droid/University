using System;

class Program
{
        static int Multiply(int a, int b)
    {
        if (b == 0)
            return 0;
        else
            return a + Multiply(a, b - 1);
    }

    static void Main()
    {
        Console.Write("Enter number 1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number 2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int result = Multiply(num1, num2);
        Console.WriteLine("Product : " + result);
    }
}