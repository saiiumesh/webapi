using System;
using System.Linq;

namespace sortingoperators
{
    class program
    {
        static void sorting()
        {
            List<Student> Objstudent = new List<Student>()
            {
                new Student() { Name = "Suresh Dasari", Gender = "Male", Subjects = new List<string> { "Mathematics", "Physics" } },
                new Student() { Name = "Rohini Alavala", Gender = "Female", Subjects = new List<string> { "Entomology", "Botany" } },
                new Student() { Name = "Praveen Kumar", Gender = "Male", Subjects = new List<string> { "Computers", "Operating System", "Java" } },
                new Student() { Name = "Sateesh Chandra", Gender = "Male", Subjects = new List<string> { "English", "Social Studies", "Chemistry" } },
                new Student() { Name = "Madhav Sai", Gender = "Male", Subjects = new List<string> { "Accounting", "Charted" } }
            };
                
            var orderbyusage = Objstudent.OrderBy(x => x.Name).First();
            var orderbyusage1 = Objstudent.OrderBy(x => x.Gender);

            var OrderByDescendingusage = Objstudent.OrderByDescending(x => x.Name);

            var thenusage = Objstudent.OrderByDescending(x => x.Name).ThenBy(x => x.Gender);
            var thenbyusage = Objstudent.OrderBy(x => x.Gender).ThenByDescending(x => x.Name);


            

        }
    }
}

