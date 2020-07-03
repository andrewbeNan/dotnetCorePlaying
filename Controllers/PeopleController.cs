using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Services;
using Models;
using Microsoft.AspNetCore.Authorization;

namespace Controllers
{
    [Produces("application/json")]
    [Route("api/people")]
    //[Authorize]
    public class PeopleController
    {

        [HttpGet("{employeeId}")]
        public Person Get(int employeeId)
        {
            var peopleService = new PeopleService();
            return peopleService.GetById(employeeId);
        }
        
        
        [HttpGet("costCentre/{employeeId}")]
        public Person GetFudged(int employeeId)
        {
            var peopleService = new PeopleService();
            return peopleService.GetById(employeeId);
        }

        // [HttpGet("costCentre/{costCentreNumber}")]
        // public IEnumerable<Person> ListPeopleInConstCentre(string costCentreNumber)
        // {
        //      IEnumerable<Person> retVal =
        //         from x in people 
        //         where x.CostCentre.Equals(costCentreNumber) 
        //         select x;

        //     return retVal;

        // }

        // [HttpGet("preferredName/{name}")]
        // public IEnumerable<Person> ListPeoplePreferredName(string name)
        // {
        //      IEnumerable<Person> retVal =
        //         from x in people 
        //         where x.PreferredName.Contains(name) 
        //         select x;

        //     return retVal;

        // }
        // [HttpGet("employeeDetails/{employeeid}")]
        // public Person EmployeeById(int employeeid)
        // {
        //      Person retVal =
        //         (from x in people 
        //         where x.EmployeeId == employeeid
        //         select x).SingleOrDefault();

        //     return retVal;

        // }
    }
}