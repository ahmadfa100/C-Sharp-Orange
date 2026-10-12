using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("===== Student Information =====");   
            Student s1 = new Student("Ahmad", 20, 3.5);
            Student s2 = new Student("Sarah", 20, 3.5);
            Student s3 = new Student("Omar", 20, 3.5);
            s1.DisplayInfo();
            Console.WriteLine();
            s2.DisplayInfo();
            Console.WriteLine();
            s3.DisplayInfo();
        }
    }
}
