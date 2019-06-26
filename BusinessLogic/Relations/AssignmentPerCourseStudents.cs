using System;
using System.Collections.Generic;
using BusinessLogic.MainClasses;

namespace BusinessLogic.Relations
{
    class AssignmentPerCourseStudents
    {
        public Student Student { get; set; }

        public AssignmentsPerCours AssigmentPerCourse { get; set; }

        public AssignmentPerCourseStudents(Student student, AssignmentsPerCours assigmentPerCourse)
        {
            Student = student;
            AssigmentPerCourse = assigmentPerCourse;
        }

        public void Output()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Student.ToString());
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (var assignment in AssigmentPerCourse.Assigments)
            {
                Console.WriteLine(assignment.ToString());
            }
        }
    }
}
