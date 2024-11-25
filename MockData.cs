using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAssignment3_3
{
    class MockData
    {

        public static List<Student> Students { get; set; }

        public static List<Student> CreateData()
        {
            Students = new List<Student>()
            {
            new Student() { StudID = 1, FirstName = "Elijah", LastName = "Rogers", Address = "Place in a place", MonthOfAdmission = Months.Mar, Grade = "A" },
            new Student() { StudID = 2, FirstName = "Alex", LastName = "Gold", Address = "Place 2", MonthOfAdmission = Months.Apr, Grade = "B" },
            new Student() { StudID = 3, FirstName = "Bob", LastName = "Silver", Address = "Place 3", MonthOfAdmission = Months.Aug, Grade = "C+" },
            new Student() { StudID = 4, FirstName = "Chris", LastName = "Diamond", Address = "Place 4", MonthOfAdmission = Months.Oct, Grade = "A+" },
            new Student() { StudID = 5, FirstName = "Kate", LastName = "Bronze", Address = "Place 5", MonthOfAdmission = Months.Jun, Grade = "D" },
            new Student() { StudID = 6, FirstName = "Julia", LastName = "Copper", Address = "Place 6", MonthOfAdmission = Months.Mar, Grade = "A" }
            };
            return Students;
        }
    }
}
