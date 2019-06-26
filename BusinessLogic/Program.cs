using BusinessLogic.MainClasses;
using BusinessLogic.Relations;
using BusinessLogic.DataBase;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    #region Enums
    enum CourseType
    {
        CSharp,
        Java
    }

    enum StreamType
    {
        FullTime,
        PartTime
    }

    enum Entities
    {
        Course,
        Trainer,
        Student,
        Assignement,
        PrintReports,
        Search
    } 
    #endregion

    class Program
    {
        
        static void Main(string[] args)
        {
            #region Main Functionality
            //---------------------------------------Main--------------------------------------------------------
            Console.WriteLine("MENU");
            Console.WriteLine("(0) Add new Course");
            Console.WriteLine("(1) Add new Trainer");
            Console.WriteLine("(2) Add new Student");
            Console.WriteLine("(3) Add new Assignment");
            Console.WriteLine("(4) Print Reports");
            Console.WriteLine("(5) students who need to submit one or more assignments on the same calendar week as the given date");
            Console.WriteLine("(9) Exit");

            
            do
            {
                Console.WriteLine();
                Console.Write("Select Action from the menu: ");
                string selection = Console.ReadLine();
                if (selection == "9")
                    break;

                switch (Convert.ToInt16(selection))
                {
                    case (short)Entities.Course:
                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Select a Stream. Please type - 0 - for FullTime, - 1 - for PartTime: ");
                        short stream = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Select Type. Please type - 0 - for C#, - 1 - for Java: ");
                        short type = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Add Start Date (DD/MM/YYYY): ");
                        DateTime startDate = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Add End Date (DD/MM/YYYY): ");
                        DateTime endDate = Convert.ToDateTime(Console.ReadLine());
                        DB.CB8.Add(new Course(title, (StreamType)stream, (CourseType)type, startDate, endDate));
                        break;
                    case (short)Entities.Trainer:
                        Console.Write("First Name: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Last Name: ");
                        string lastName = Console.ReadLine();
                        Console.Write("Select Type. Please type - 0 - for C#, - 1 - for Java: ");
                        short subject = Convert.ToInt16(Console.ReadLine());
                        DB.trainersDB.Add(new Trainer((CourseType)subject, firstName, lastName));
                        break;
                    case (short)Entities.Student:
                        Console.Write("First Name: ");
                        string stFirstName = Console.ReadLine();
                        Console.Write("Last Name: ");
                        string stLastName = Console.ReadLine();
                        Console.Write("Add Date of Birth (DD/MM/YYYY): ");
                        DateTime birthDate = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Charged Fees: ");
                        decimal fees = Convert.ToDecimal(Console.ReadLine());
                        DB.studentsDB.Add(new Student(stFirstName, stLastName, birthDate, fees));
                        break;
                    case (short)Entities.Assignement:
                        Console.WriteLine("Assignement Title: ");
                        string assTitle = Console.ReadLine();
                        Console.WriteLine("Description: ");
                        string assDescr = Console.ReadLine();
                        Console.WriteLine("Submition Date & Time (DD/MM/YYYY HH:MM): ");
                        DateTime subDateTime = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Oral mark: ");
                        double oralMark = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Total mark: ");
                        double totalMark = Convert.ToDouble(Console.ReadLine());
                        DB.assignmentsDB.Add(new Assignment(assTitle, assDescr, subDateTime, oralMark, totalMark));
                        break;
                    case (short)Entities.PrintReports:
                        Console.WriteLine();

                        //Print All Courses
                        Console.WriteLine("All Courses");
                        Console.ForegroundColor = ConsoleColor.Red;
                        foreach (var course in DB.CB8)
                        {
                            Console.WriteLine(course.ToString());
                        }
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine();

                        //Print All Trainers
                        Console.WriteLine("List of All Trainers");
                        Console.ForegroundColor = ConsoleColor.Green;
                        foreach (var trainer in DB.trainersDB)
                        {
                            Console.WriteLine(trainer.ToString());
                        }
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine();

                        //Print All Students
                        Console.WriteLine("List of All Students");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        foreach (var student in DB.studentsDB)
                        {
                            Console.WriteLine(student.ToString());
                        }
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine();

                        //Print All Assignments
                        Console.WriteLine("List of All Assignments");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        foreach (var assignment in DB.assignmentsDB)
                        {
                            Console.WriteLine(assignment.ToString());
                        }
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine();

                        //Print Students per Course
                        Console.WriteLine("List of All Students per Course");
                        foreach (var course in DB.studentsPerCourse)
                        {
                            course.Output();
                        }
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine();

                        //Print Trainers per Course
                        Console.WriteLine("List of All Trainers per Course");
                        foreach (var course in DB.trainersPerCourse)
                        {
                            course.Output();
                        }
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine();

                        //Print Assignments per Course
                        Console.WriteLine("List of All Assignments per Course");
                        foreach (var course in DB.assignmentsPerCourse)
                        {
                            course.Output();
                            
                        }
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine();

                        //PrintAll the assignments per student
                        Console.WriteLine("List of All Assignments per student");
                        foreach (var studentAssingments in DB.assignmentPerCourseStudents)
                        {
                            studentAssingments.Output();
                        }
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine();

                        //A list of students that belong to more than one courses
                        int count;
                        Console.WriteLine("list of students that belong to more than one courses");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        foreach (var student in DB.studentsDB)
                        {
                            count = 0;
                            foreach (var course in DB.studentsPerCourse)
                            {
                                foreach (var courseStudent in course.Students)
                                {
                                    if (student.Equals(courseStudent))
                                        count++;
                                } 
                            }
                            if(count>1)
                                Console.WriteLine($"{student.ToString()} follows {count} courses");
                        }
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine();
                        break;
                    case (short)Entities.Search:
                        Console.Write("Date (DD/MM/YYYY): ");
                        DateTime searchDate = Convert.ToDateTime(Console.ReadLine());

                        count = 0;
                        foreach (var student in DB.assignmentPerCourseStudents)
                        {
                            foreach (var assignment in student.AssigmentPerCourse.Assigments)
                            {
                                if (assignment.SubDateTime.Year == searchDate.Year && assignment.SubDateTime.Month == searchDate.Month)
                                    if (GetWeekNumberOfMonth(assignment.SubDateTime) == GetWeekNumberOfMonth(searchDate))
                                    {
                                        Console.WriteLine(student.Student.ToString());
                                        count++;
                                    }
                            }
                        }
                        if(count==0)
                            Console.WriteLine("No Data Found for this date");
                        break;
                    default:
                        Console.WriteLine("Wrong selection!");
                        break;
                }
            } while (true); 
            #endregion
        }

        public static int GetWeekNumberOfMonth(DateTime date)
        {
            date = date.Date;
            DateTime firstMonthDay = new DateTime(date.Year, date.Month, 1);
            DateTime firstMonthMonday = firstMonthDay.AddDays((DayOfWeek.Monday + 7 - firstMonthDay.DayOfWeek) % 7);
            if (firstMonthMonday > date)
            {
                firstMonthDay = firstMonthDay.AddMonths(-1);
                firstMonthMonday = firstMonthDay.AddDays((DayOfWeek.Monday + 7 - firstMonthDay.DayOfWeek) % 7);
            }
            return (date - firstMonthMonday).Days / 7 + 1;
        }
    }
}
