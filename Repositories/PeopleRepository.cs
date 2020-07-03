using Models;
using System;
using System.Linq;

namespace Repositories
{
    public class PeopleRepository
    {

        Person[] people = new Person[]
            {
            new Person {EmployeeId = 014600301, PreferredName = "Teddy", CostCentre = "N001", JobRole="Tramp" },
            new Person {EmployeeId = 014600302, PreferredName = "Andrew B", CostCentre = "N002", JobRole="Tramp1" },
            new Person {EmployeeId = 014600303, PreferredName = "David B", CostCentre = "N003", JobRole="Tramp2" },
            new Person {EmployeeId = 014600304, PreferredName = "Bozo the clown", CostCentre = "N003", JobRole="Tramp2" },
            new Person {EmployeeId = 014600305, PreferredName = "Mary the jester", CostCentre = "N003", JobRole="Tramp2" }
            };

        public Person GetById(int employeeId)
        {
            Person person =
                (from x in people
                 where x.EmployeeId == employeeId
                 select x).SingleOrDefault();

            return person;
        }
    }
}