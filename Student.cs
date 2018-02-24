using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collec
{
    class Student : IComparable<Student>
    {
        public int SId;
        public string SName;
        public float SMarks;

        public int CompareTo(Student other)
        {
            if (this.SId > other.SId)
                return 1;
            else if (this.SId < other.SId)
                return -1;
            else
                return 0;
        }
    }
    class Sample
    {
        public static int CompareNames(Student s1, Student s2)
        {
            return s1.SName.CompareTo(s2.SName);
        }
        static void Main(string[] args)
        {
            Student obj1 = new Student { SId = 101, SName = "sivani", SMarks = 83.3f };
            Student obj2 = new Student { SId = 103, SName = "anusha", SMarks = 79.5f };
            Student obj3 = new Student { SId = 108, SName = "aruna", SMarks = 82.3f };
            Student obj4 = new Student { SId = 102, SName = "lakshmi", SMarks = 65.8f };
            List<Student> l = new List<Student> { obj1, obj2, obj3, obj4 };
            l.Sort();
            l.Sort((s1, s2) => s1.SName.CompareTo(s2.SName));
            foreach (Student obj in l)
            {
                Console.WriteLine(obj.SId + " " + obj.SName + " " + obj.SMarks);
            }
            Console.WriteLine("after reveersing the student details are:");
            l.Reverse();

            foreach (Student obj in l)
            {
                Console.WriteLine(obj.SId + " " + obj.SName + " " + obj.SMarks);
            }
            Console.ReadLine();
        }
    }
}
