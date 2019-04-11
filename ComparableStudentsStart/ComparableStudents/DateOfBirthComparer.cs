using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableStudents
{
    class DateOfBirthComparer : IComparer<Student>
        //így már nem kell castolgatni, mert az auto implementeli
    {
        //public int Compare(object x, object y)
        //{
        //    Student st1 = x as Student;
        //    Student st2 = y as Student;
        //    return st1.DateOfBirth.CompareTo(st2.DateOfBirth);
        //}

        public int Compare(Student x, Student y)
        {
          //  Console.WriteLine("IComparer");
           return x.DateOfBirth.CompareTo(y.DateOfBirth);
        }
    }
}
