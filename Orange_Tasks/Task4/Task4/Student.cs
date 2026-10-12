using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Student
    {
        public string studentName;
        public int StudentAge;
        public double studentGrade;


        public Student(string sName, int sAge, double sGrade)
        {
            studentName = sName;
            StudentAge = sAge;
            studentGrade = sGrade;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Student Age: " + StudentAge);
            Console.WriteLine("Student Grade: " + studentGrade);
        }
    }
}
