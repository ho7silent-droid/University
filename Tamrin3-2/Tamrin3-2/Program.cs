using System;
class program
{
    static void Main()
    {
        Console.Write("Enter a letter (E,H,I): ");
        string Harf = Console.ReadLine();
    
    for (int i = 1; i <= 5; i++)
        {
            switch (Harf)
            {
                case "E":
                    if (i == 1 || i == 3 || i == 5)

                        Console.WriteLine("*****");
                    else
                        Console.WriteLine("*");
                            break;

                case "H":
                    if (i == 3)
                        Console.WriteLine("*****");
                    else
                        Console.WriteLine("*   *");
                    break;

                case "I":
                    if (i == 1 || i == 5)

                        Console.WriteLine("*****");
                    else
                        Console.WriteLine("  *  ");
                    break;

                default:
                    Console.WriteLine("Errorrr:) ");
                    return;
            }
        }
                
                
                
                
                
                }
}