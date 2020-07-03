
using Models;
using Repositories;

namespace Services
{
    public class PeopleService
    {
        public Person GetById(int employeeId)
        {
            var peopleRepository = new PeopleRepository();
            var person = peopleRepository.GetById(employeeId);
            if (person != null)
            {
                var hoursRepository = new HoursRepository();
                person.HoursWorked = hoursRepository.GetByEmployeeId(person.EmployeeId);
            }
            return person;
        }
    }
}