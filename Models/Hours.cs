using System;

namespace Models
{
    public class Hours
    {
        public int EmployeeId {get; set;}
        public DateTime Day {get; set;}
        public EnumHours HoursWorked {get; set;}
        public bool Approved {get; set;}
    }

    public enum EnumHours {
        NotWorked = 0,
        HalfDay = 1,
        FullDay = 2
    }
}