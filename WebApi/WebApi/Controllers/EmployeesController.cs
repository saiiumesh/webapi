using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class EmployeesController : ApiController
    {
        // GET: api/Employees
        public IEnumerable<Employee> Get()
        {
            using (EmployeeDBEntities1 entities = new EmployeeDBEntities1())
            {
                return entities.Employees.ToList();
            }
        }

        // GET: api/Employees/5
        public Employee Get(int id)
        {
            using (EmployeeDBEntities1 entities = new EmployeeDBEntities1())
            {
                return entities.Employees.FirstOrDefault(e => e.ID==id);   
            }


        }

        // POST: api/Employees
        public void Post([FromBody]Employee employee)
        {
            using (EmployeeDBEntities1 entities = new EmployeeDBEntities1())
            {
                entities.Employees.Add(employee);
                entities.SaveChanges();


            }

        }

        // PUT: api/Employees/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employees/5
        public void Delete(int id)
        {
        }
    }
}
