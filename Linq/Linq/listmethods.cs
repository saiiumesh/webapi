using System;
using System.Linq;

namespace listmethods
{
    class Program
    {
        static void aggregatefunctions()
        {
            int [] a= {1,2,3,4,5,6,7,8,9,10};

            Console.WriteLine("the min number is",a.Min(),
                "the max no is:",a.Max(),
                "the aggregate is:",a.Aggregate((a,b)=>a+b),
                "the count is:",a.Count(),
                "the sum is:",a.Sum()
                );



        }

        
    }
}