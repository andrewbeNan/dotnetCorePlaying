using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public class HoursRepository
    {

        Hours[] hoursWorked = new Hours[]
            {
            new Hours {EmployeeId = 014600301, Day = DateTime.Parse("2020-05-01"), HoursWorked = EnumHours.HalfDay, Approved=false },
            new Hours {EmployeeId = 014600301, Day = DateTime.Parse("2020-05-02"), HoursWorked = EnumHours.FullDay, Approved=false },
            new Hours {EmployeeId = 014600301, Day = DateTime.Parse("2020-05-03"), HoursWorked = EnumHours.NotWorked, Approved=true },
            new Hours {EmployeeId = 014600301, Day = DateTime.Parse("2020-05-12"), HoursWorked = EnumHours.FullDay, Approved=false },
            };

        public List<Hours> GetByEmployeeId(int employeeId)
        {
            return 
            (from x in hoursWorked
             where x.EmployeeId == employeeId
             select x).ToList();

        }
    }
}