using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAssignment3_3
{
    // Create a class: Student with fields like studid, firstname, lastname, address,monthofadmission,grade to hold character.
    public enum Months { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sept, Oct, Nov };
    public class Student
    {
        public int StudID { get; set; }// Key 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public Months MonthOfAdmission { get; set; }
        public string Grade { get; set; }

        // Adds a new student object to the list of Students (Best to have an indication of competion or failure)
        public static void AddStudent_Click(Student student)
        {
            MockData.Students.Add(student);
        }

        // Removes a student based on their id (Best to have an indication of competion or failure)
        public static void RemoveStudent_Click(int id)
        {
            foreach (Student student in MockData.Students)
            {
                if (student.StudID == id)
                {
                    MockData.Students.Remove(student);
                    break;
                }
            }
        }
    }
}
