using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program8
    {
        public int RollNo;
        public string StudName;
        public double MarksInEng;
        public double MarksInMaths;
        public double MarksInScience;
        public double marks;
        public double percentage;
        public void Details()
        {
            Console.WriteLine("RollNo: " + RollNo);
            Console.WriteLine(" StudName: " + StudName);
            Console.WriteLine("MarksInEng: " + MarksInEng);
            Console.WriteLine("MarksInMaths: " + MarksInMaths);
            Console.WriteLine("MarksInScience: " + MarksInScience);
        }
        public void markAdd()
        {
            marks = MarksInScience + MarksInEng + MarksInMaths;
            Console.WriteLine("Marks: " + marks);
        }
        public void perc()
        {
            percentage = marks / 3;
            Console.WriteLine("Percentage: " + percentage);
        }
    }
    class Program8Test
    {
        public static void Main()
        {

            Program8 s1 = new Program8();
            s1.RollNo = 84;
            s1.StudName = "Ranjan Pathak";
            s1.MarksInMaths = 77.00;
            s1.MarksInScience = 48.00;
            s1.MarksInEng = 99.00;
            s1.Details();
            s1.markAdd();
            s1.perc();

            Program8 s2 = new Program8();
            s2.RollNo = 78;
            s2.StudName = "Anish";
            s2.MarksInMaths = 37.00;
            s2.MarksInScience = 95.00;
            s2.MarksInEng = 87.00;
            s2.Details();
            s2.markAdd();
            s2.perc();
            Console.ReadKey();
        }
    }
}