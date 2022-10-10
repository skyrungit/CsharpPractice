using RoadBook.CsharpBasic.Chapter06.Examples.Model;
using System;
using System.Collections;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class Ex014
    {
        public void Run()
        {
            ArrayList arrStudent = new ArrayList();

            Student student = new Student();

            student.ID = "S001";
            student.Name = "Jane";
            student.Department = "Korean";
            student.Grade = 1;
            student.Age = 21;

            arrStudent.Add(student);

            for (int idx = 0; idx < arrStudent.Count; idx++)
            {
                Console.WriteLine(((Student)arrStudent[idx]).ID);
                Console.WriteLine(((Student)arrStudent[idx]).Name);
                Console.WriteLine(((Student)arrStudent[idx]).Department);
                Console.WriteLine(((Student)arrStudent[idx]).Grade);
                Console.WriteLine(((Student)arrStudent[idx]).Age);
            }
        }
    }
}
