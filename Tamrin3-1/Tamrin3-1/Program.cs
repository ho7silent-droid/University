using System;
class program
{
    static void Main()
    {
        Console.Write("Enter a number between 1 and 7: ");
        int n =
            int.Parse(Console.ReadLine());
        switch (n)
        {
            case 1:
                Console.WriteLine("Saturday");
                break;
            case 2:
                Console.WriteLine("Sanday");
                break;
            case 3:
                Console.WriteLine("Monday");
                break;
            case 4:
                Console.WriteLine("Tuesday");
                break;
            case 5:
                Console.WriteLine("Wednesday");
                break;
            case 6:
                Console.WriteLine("Thursday");
                break;
            case 7:
                Console.WriteLine("Friday");
                break;
            default:
                Console.WriteLine("End!");
                break;
        }
    }
}