using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableStudents
{
    public class Student : IComparable<Student>
    {
        public DateTime DateOfBirth { get; set; }
        public string Name { get; set; }

        /*public int CompareTo(object obj)
             //implementálom a kötelező metódust
         {
             Student otherstudent = (Student)obj;
             return this.Name.CompareTo(otherstudent.Name);
             //mivel van a stringnek már impelentált compareto metódusa, használhatom
         }*/

        public int CompareTo(Student other)
        {
            return this.Name.CompareTo(other.Name);
        }

        //public int CompareTo(object obj)
        ////implementálom a kötelező metódust
        //{
        //    Student otherStudent = (Student)obj;
        //    return this.DateOfBirth.CompareTo(otherStudent.DateOfBirth);
        //    //mivel van a stringnek már impelentált CompareTo metódusa, használhatom
        //}

        public override string ToString()
        {
            return $"{Name} {DateOfBirth.ToShortDateString()}";
        }
    }
}
