using System;

class program
{
    static void Main()
    {
        int[] arr = new int[10];
        int zoj = 0;
        int fard = 0;

        Console.WriteLine("Enter 10 numbers");

        for (int i = 0; i < 10; i++)
        {

            arr[i] = int.Parse(Console.ReadLine());
        }
        foreach (int x in arr)
        {
            if (x % 2 == 0)
                zoj++;
            else
                fard++;
        }
        Console.WriteLine("Number of zoj numbers: " + zoj);
        Console.WriteLine("Number of fasd numbers: " + fard);
    }
}