using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_sys_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = "Ahmad Bani Hamad";
            int    studentAge = 20;
            float studentGrade= 123.4567890f;
            string studentEmail = "ahmad.banihamad@example.com";
            double studentAverage = 123.4567890;
            string studentGender = "Male";
            bool   isStudentActive = true;

            Console.WriteLine("========== Student Information ============");
            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Student Age: " + studentAge);
            Console.WriteLine("Student Grade: " + studentGrade);
            Console.WriteLine("Student Email: " + studentEmail);
            Console.WriteLine("Student Average: " + studentAverage);
            Console.WriteLine("Student Gender: " + studentGender);
            Console.WriteLine("Is Student Active: " + isStudentActive);


            // -----------------------
            string[] studentNames = { "Ahmad", "Mohammad", "Waleed", "Khaled" };

            Console.WriteLine("========== Student Names ============");
            Console.WriteLine("Student 1:" + studentNames[0]);
            Console.WriteLine("Student 2:" + studentNames[1]);
            Console.WriteLine("Student 3:" + studentNames[2]);
            Console.WriteLine("Student 4:" + studentNames[3]);

            Console.WriteLine("Number of Students: " + studentNames.Length);

            Console.WriteLine("======== before change ========");
            Console.WriteLine(studentNames[0]);
            Console.WriteLine(studentNames[1]);
            Console.WriteLine(studentNames[2]);
            Console.WriteLine(studentNames[3]);


            Console.WriteLine("======= After change ========");
            studentNames[2]="Omar";
            studentNames[3] = "Lina";
            Console.WriteLine(studentNames[0]);
            Console.WriteLine(studentNames[1]);
            Console.WriteLine(studentNames[2]);
            Console.WriteLine(studentNames[3]);

        }
    }
}
