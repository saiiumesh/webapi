using System;
using System.Linq;
namespace partitionops

{
    class program
    {
        static void partsops()
        {
            string[] countries = { "India", "USA", "Russia", "China", "Australia", "Argentina" };

            IEnumerable<string> result = countries.Take(3);
            Console.WriteLine(result);
            IEnumerable<string> result2 = countries.TakeWhile(x=>x.StartsWith('I'));
            Console.WriteLine(result2);

            IEnumerable<string> result3 = countries.Skip(2);
            Console.WriteLine(result3);
            IEnumerable<string> result4 = countries.SkipWhile(x => x.EndsWith('a'));
        }
    }
}
