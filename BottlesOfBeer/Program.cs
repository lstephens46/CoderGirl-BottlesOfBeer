using System;

namespace BottlesOfBeer
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Output "99 bottles of beer on the wall.  99 bottles of beer.  Take 1 down and pass it around, 98 bottles of beer on the wall.";
            // Count down until there are no more bottles of beer on the wall.


            for (int bottle = 99; bottle <= 99; bottle--)
                if (bottle <= 99 && bottle >= 1)
                {
                    Console.WriteLine($"{bottle} bottles of beer on the wall.  {bottle} bottles of beer.  Take 1 down and pass it around, {bottle - 1} bottles of beer on the wall.");
                }
            Console.ReadLine();
        }


    }
}
