using System;
using System.Collections.Generic;
using BusinessLogic.MainClasses;

namespace BusinessLogic.Relations
{
    class TrainersPerCourse
    {
        public Course Course { get; set; }
        public List<Trainer> Trainers { get; set; }

        public TrainersPerCourse(Course course, List<Trainer> trainers)
        {
            Course = course;
            Trainers = trainers;
        }

        public void Output()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Course.ToString());
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var trainer in Trainers)
            {
                Console.WriteLine(trainer.ToString());
            }
        }
    }
}
