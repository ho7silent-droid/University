using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[5];
        bool found = false;

        int position = 0;

        Console.WriteLine("Enter 5 Numbers");

        for (int i = 0; i < 5; i++)
        {

            arr[i] = int.Parse(Console.ReadLine());
        }
        int counter = 1;
        
        foreach (int x in arr)
        {

            if (x == 2)
            {
                found = true;
                position = counter;
                break;
            }
            counter++;
        }
        if (found == true)
            Console.WriteLine("The number 2 exist,it was the " + position + "number");
        else
            Console.WriteLine("The number 2 does not exist");
    }
}