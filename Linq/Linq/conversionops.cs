using System;
using System.Collections;
using System.Linq;
using System.Xml.Linq;

namespace convs
{
    class program
    {
        public static void convops()
        {
            string[] countries = { "US", "UK", "India", "Russia", "China", "Australia", "Argentina" };

            List<string> countrieslist = countries.ToList();

            string[] countries1 = { "Uk", "Us", "Russia", "India", "Argentina", "Australia", "China" };
            
            string[] countryarray = countries1.ToArray();

            List<Employee> objEmployee = new List<Employee>()
            {
                new Employee(){ Name="Akshay Tyagi", Department="IT", Country="India"},
                new Employee(){ Name="Vaishali Tyagi", Department="Marketing", Country="Australia"},
                new Employee(){ Name="Arpita Rai", Department="HR", Country="China"},
                new Employee(){ Name="Shubham Ratogi", Department="Sales", Country="USA"},
                new Employee(){ Name="Himanshu Tyagi", Department="Operations", Country="Canada"}
            };
            //objEmployee.ToLookup() method is used to print the value of the data in the pair/collection of items.  
            var Emp = objEmployee.ToLookup(x => x.Department);
            Console.WriteLine("Grouping Employees by Department");
            
            foreach (var KeyValuePair in Emp)
            {
                Console.WriteLine(KeyValuePair.Key);
                // Lookup employees by Department  
                foreach (var item in Emp[KeyValuePair.Key])
                {
                    Console.WriteLine("\t" + item.Name + "\t" + item.Department + "\t" + item.Country);
                }


                var todicts = objEmployee.ToDictionary(x=>x.Name, x => x.Department);


               
            }
            Console.ReadLine();
        }

        
 




    }
    class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Country { get; set; }
    }
}  



 