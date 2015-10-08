using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.Provider;

namespace MvcMovie2.API.Controllers
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    
    public class PersonController : ApiController
    {
        // GET api/values
        public IEnumerable<Person> Get()
        {
            return new Person[]
            {
                new Person{Id = 0, FirstName = "Bob", LastName = "Walker"},
                new Person{Id = 1, FirstName = "Scott", LastName = "Hutner"},  
                new Person{Id = 2, FirstName = "Bob", LastName = "Burnquist"},
                new Person{Id = 3, FirstName = "Mikael", LastName = "Akerfeldt"},
            };
        }

        // GET api/values/5
        public  Person Get(int id)
        {
            return null;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
