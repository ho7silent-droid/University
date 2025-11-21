using System;

class Program
{

    static double Mohit(double a, double b, double c)
    {
        return a + b + c;
    }

    static double Masahat(double a, double b, double c)
    {
        double s = Mohit(a, b, c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    static void Main()
    {
        Console.Write("Enter side 1: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 2: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 3: ");
        double c = Convert.ToDouble(Console.ReadLine());

      
        double mohit = Mohit(a, b, c);
        double masahat = Masahat(a, b, c);

        Console.WriteLine("Mohit triangle : " + mohit);
        Console.WriteLine("Masahat triangle : " + masahat);
    }
}