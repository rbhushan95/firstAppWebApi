using Entities;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace firstAppServiceApi.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class EmployeeController : ApiController
    {
        public List<Employee> GetAll()
        {
            List<Employee> listEmp = new List<Employee>();

            return listEmp;
        }
    }
}
