using System;
using System.Linq;

namespace linqmethods
{

    public class Program
    {
        static void Main()
        {
            List<int> list = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10,11,12,13,14
            };


            // using query syntax
            var querysyntax = from number in list
                              where number>=5
                              select number;

            Console.WriteLine("using query syntrax below is the result:");

            foreach (var item in querysyntax)
            {

                Console.WriteLine(item + "");

            }

                var methodsyntax = list.Where(x => x >= 5).ToList();
            Console.WriteLine("using methodsyntax");

            foreach(var item in methodsyntax)
            {
                Console.WriteLine(item +"");
            }
            

            // using mixed synatax



            var mixedsyntax = (from number in list
                              where number>=5
                              select number).Sum();

            Console.WriteLine(mixedsyntax);


                Console.ReadKey();


            
        }



        
    }
}