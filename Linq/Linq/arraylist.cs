using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList obj = new ArrayList();
            obj.Add("Australia");
            obj.Add("India");
            obj.Add("UK");
            obj.Add("USA");
            obj.Add(1);


            IEnumerable<string> casting = obj.Cast<string>();
             
            IEnumerable<string> result = obj.OfType<string>();
            
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }



            int[] NumArray = new int[] { 1, 2, 3, 4, 5 };
             
            var ienumresult = NumArray.AsEnumerable();


            Console.ReadLine();
        }
    }
}