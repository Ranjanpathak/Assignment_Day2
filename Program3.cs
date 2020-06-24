using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program3
    {
        public static void Main()
        {
            MarksStudent m1 = new MarksStudent
            {
                RollNo = 1160,
                Name = "Rahul",
                ClassName = 12,
                Semester = 8,
                Branch = "CSE",

            };
            m1.Marks[0] = 50.0;
            m1.Marks[1] = 60.0;
            m1.Marks[2] = 70.0;
            m1.Marks[3] = 80.0;
            m1.Marks[4] = 90.0;

            m1.Average = m1.CalculateAverage();
            m1.Result = m1.PassFail();
            m1.Display();
            Console.ReadLine();
        }
    }
}