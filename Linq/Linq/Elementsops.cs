using System;
using System.Linq;

namespace elementops
{
    class program
    {
        static void Main()
        {
            int[] list = { 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine(list.First());
            Console.WriteLine(list.FirstOrDefault());
            Console.WriteLine(list.Last());
            Console.WriteLine(list.LastOrDefault());
            Console.WriteLine(list.ElementAt(3));
            Console.WriteLine(list.ElementAtOrDefault(4));
            Console.WriteLine(list.Single(x=>x<5));
            Console.WriteLine(list.SingleOrDefault(x=>x>6));
            Console.WriteLine(list.DefaultIfEmpty());

            Console.ReadKey(); 

        }
    }
}