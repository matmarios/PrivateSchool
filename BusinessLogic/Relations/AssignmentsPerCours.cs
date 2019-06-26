using System;
using System.Collections.Generic;
using BusinessLogic.MainClasses;

namespace BusinessLogic.Relations
{
    class AssignmentsPerCours
    {
        public Course Course { get; set; }

        public List<Assignment> Assigments { get; set; }

        public AssignmentsPerCours(Course course, List<Assignment> assigments)
        {
            Course = course;
            Assigments = assigments;
        }

        public void Output()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Course.ToString());
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var assigment in Assigments)
            {
                Console.WriteLine(assigment.ToString());
            }
        }
    }
}
