using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Student> students = new List<Student>
            {                
                new Student{ Name = "Balázs", DateOfBirth = new DateTime(2000,10,21)},
                new Student{ Name = "Emma", DateOfBirth = new DateTime(2013,1,11)},
                new Student{ Name = "Áron", DateOfBirth = new DateTime(2010,9,28)}
               
            };
            students.Sort( new DateOfBirthComparer());
            //overloadolható a Sort metódus egy ilyen paraméterrel

            Console.WriteLine(string.Join("\n", students));
        }
    }
}
