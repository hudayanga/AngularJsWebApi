using DataAccessLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class EmployeeController : ApiController
    {
        // GET api/values
        public IEnumerable<Employee> Get()
        {
            using (EmployeeDbEntities eDb = new EmployeeDbEntities())
            {

                var employees = eDb.Employees.ToList();
                return employees;
            }

        }

        // GET api/values/4branchCom
        public Employee Get(int id)
        {
            using (EmployeeDbEntities eDb = new EmployeeDbEntities())
            {

                var employee = eDb.Employees.FirstOrDefault(x=>x.Id==id);
                return employee;
            }
        }

        // POST api/values
        public void Post([FromBody]Employee employee)
        {
            using (EmployeeDbEntities eDb = new EmployeeDbEntities())
            {

                eDb.Employees.Add(employee);
                eDb.SaveChanges();
            }
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Employee emp)
        {
            using (EmployeeDbEntities eDb = new EmployeeDbEntities())
            {

                var employee = eDb.Employees.FirstOrDefault(x => x.Id == id);
                employee.EName = emp.EName;
                eDb.SaveChanges();
               
            }
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            using (EmployeeDbEntities eDb = new EmployeeDbEntities())
            {

                var employee = eDb.Employees.FirstOrDefault(x => x.Id == id);

                eDb.Employees.Remove(employee);
                eDb.SaveChanges();

            }
        }
    }
}
