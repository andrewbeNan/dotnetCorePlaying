using System;
using System.Collections.Generic;

namespace Models
{
    public class Person
    {
        public int EmployeeId {get; set;}
        public string PreferredName {get; set;}
        public string CostCentre {get; set;}
        public string JobRole {get; set;}
        public List<Hours> HoursWorked {get; set;}
    }
}