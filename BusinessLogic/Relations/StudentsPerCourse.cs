using System;
using System.Collections.Generic;
using BusinessLogic.MainClasses;

namespace BusinessLogic.Relations
{
    class StudentsPerCourse
    {
        public Course Course { get; set; }
        public List<Student> Students { get; set; }

        public StudentsPerCourse(Course course, List<Student> students)
        {
            Course = course;
            Students = students;
        }

        public void Output()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Course.ToString());
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var student in Students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
