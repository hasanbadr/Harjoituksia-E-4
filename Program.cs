using System;

class Program
{
    static void Main()
    {
        Console.Write("Syötä ensimmäinen kokonaisluku: ");
        int luku1 = int.Parse(Console.ReadLine());

        Console.Write("Syötä toinen kokonaisluku: ");
        int luku2 = int.Parse(Console.ReadLine());

        if (luku1 > 0 && luku2 > 0)
        {
            Console.WriteLine("Molemmat ovat positiivisia.");
        }
        else if (luku1 < 0 && luku2 < 0)
        {
            Console.WriteLine("Molemmat ovat negatiivisia.");
        }
        else
        {
            Console.WriteLine("Toinen on positiivinen ja toinen negatiivinen.");
        }
    }
}