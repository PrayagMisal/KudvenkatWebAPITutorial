using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeService.Controllers
{
    [Authorize]
    public class EmployeesController : ApiController
    {
        EmployeeDBEntities entities = new EmployeeDBEntities();
        public IEnumerable<Employee> Get()
        {
            return entities.Employees.ToList();
        }
    }
}
