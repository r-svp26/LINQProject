using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQProject
{
    public class LinqToEntities
    {
        /// <summary>
        /// list of student
        /// </summary>
        public static void Entities() 
        {
            Student[] studentArray = {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve", Age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill", Age = 25 },
            new Student() { StudentID = 4, StudentName = "Ram", Age = 20 },
            new Student() { StudentID = 5, StudentName = "Ron", Age = 31 },
            new Student() { StudentID = 6, StudentName = "Chris", Age = 27 },
            new Student() { StudentID = 7, StudentName = "Rob", Age = 19 },
            };
            //// used to find the students of age between 12 & 20 and store it in array
            Student[] teenAgerStudents = studentArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();
            foreach (Student student in teenAgerStudents)
            {
                Console.WriteLine("Id:-" + student.StudentID + " " + "Name:-" + student.StudentName + " " + "Age:-" + student.Age +"\n");
            }
            //// Use LINQ to find student whose name is bill
            Student bill = studentArray.Where(s => s.StudentName == "Bill").FirstOrDefault();
            Console.WriteLine("Id:-" + bill.StudentID + " " + "Name:-" + bill.StudentName + " " + "Id:-" + bill.Age + "\n");
            //// Use LINQ to find student whose StudentID is 5
            Student student5 = studentArray.Where(s => s.StudentID == 5).FirstOrDefault();
            Console.WriteLine("Id:-" + student5.StudentID + " " + "Name:-" + student5.StudentName + " " + "Id:-" + student5.Age + "\n");
        }
    }
}
