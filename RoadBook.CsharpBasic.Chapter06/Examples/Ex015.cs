using RoadBook.CsharpBasic.Chapter06.Examples.Model;
using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class Ex015
    {
        public void Run()
        {
            List<Student> arrStudent = new List<Student>();

            Student student = new Student();
            student.ID = "S002";
            student.Name = "Thor";
            student.Department = "English";
            student.Grade = 2;
            student.Age = 31;

            arrStudent.Add(student);

            for (int idx = 0; idx < arrStudent.Count; idx++)
            {
                Console.WriteLine(arrStudent[idx].ID);
                Console.WriteLine(arrStudent[idx].Name);
                Console.WriteLine(arrStudent[idx].Department);
                Console.WriteLine(arrStudent[idx].Grade);
                Console.WriteLine(arrStudent[idx].Age);
            }
        }
    }
}
