using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;
using OdataWebApiV1.Models;

namespace OdataWebApiV1.Controllers
{
    public class ValuesController : ApiController
    {

        private List<Employee> _employees = new List<Employee>
        {
            new Employee()
            {
                Id = 1,
                FirstName = "Ibrahim",
                LastName = "Sassi"
            },
            new Employee()
            {
                Id = 2,
                FirstName = "Badran",
                LastName = "Wiwww"
            },
            new Employee()
            {
                Id = 3,
                FirstName = "Daruo",
                LastName = "Matrix"
            },
            new Employee()
            {
                Id = 4,
                FirstName = "Hakim",
                LastName = "FirasNarimen"
            },
        };

        // GET api/values
        [EnableQuery]
        public IEnumerable<Employee> Get()
        {
            return _employees;
        }

        // GET api/values/5
        [EnableQuery]
        public Employee Get(int id)
        {
            return _employees.Find(employee => employee.Id == id);
        }

        // POST api/values
        [EnableQuery]
        public IEnumerable<Employee> Post([FromBody]Employee employee)
        {

            _employees.Add(employee);
            return _employees;

        }

        // PUT api/values/
        [EnableQuery]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [EnableQuery]
        public IEnumerable<Employee> Delete(int id)
        {


            _employees.Remove(_employees.Find(employee => employee.Id==id));
            return _employees;


        }
    }
}
