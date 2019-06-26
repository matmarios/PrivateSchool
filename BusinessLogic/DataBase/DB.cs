using System;
using System.Collections.Generic;
using BusinessLogic.MainClasses;
using BusinessLogic.Relations;

namespace BusinessLogic.DataBase
{
    static class DB
    {
        public static List<Course> CB8 = new List<Course>();
        public static List<StudentsPerCourse> studentsPerCourse = new List<StudentsPerCourse>();
        public static List<TrainersPerCourse> trainersPerCourse = new List<TrainersPerCourse>();
        public static List<Student> studentsDB = new List<Student>();
        public static List<Trainer> trainersDB = new List<Trainer>();
        public static List<Assignment> assignmentsDB = new List<Assignment>();
        public static List<AssignmentsPerCours> assignmentsPerCourse = new List<AssignmentsPerCours>();
        public static List<AssignmentPerCourseStudents> assignmentPerCourseStudents = new List<AssignmentPerCourseStudents>();
        static DB()
        {
            Initialize();
        }

        private static void Initialize()
        {
            //Student Data Base
            Student S1 = new Student("Marios", "Matthioulakis", new DateTime(1978, 11, 2), 2500M);
            Student S2 = new Student("Nikos", "Nikolakakis", new DateTime(1979, 9, 22), 2500M);
            Student S3 = new Student("Kostas", "Konsta", new DateTime(1981, 5, 20), 2500M);
            Student S4 = new Student("Vassilis", "Vass", new DateTime(1982, 6, 25), 2500M);
            Student S5 = new Student("Kostas", "pap", new DateTime(1983, 5, 20), 2500M);
            Student S6 = new Student("giannis", "gian", new DateTime(1983, 2, 20), 2500M);
            Student S7 = new Student("Alekos", "Alex", new DateTime(1983, 5, 20), 2500M);
            Student S8 = new Student("Spyros", "Vront", new DateTime(1983, 3, 20), 2500M);
            Student S9 = new Student("Aliki", "Soum", new DateTime(1983, 5, 20), 2500M);
            Student S10 = new Student("Maria", "Mario", new DateTime(1980, 6, 20), 2500M);
            studentsDB.Add(S1);
            studentsDB.Add(S2);
            studentsDB.Add(S3);
            studentsDB.Add(S4);
            studentsDB.Add(S5);
            studentsDB.Add(S6);
            studentsDB.Add(S7);
            studentsDB.Add(S8);
            studentsDB.Add(S9);
            studentsDB.Add(S10);

            //Trainers Data Base
            Trainer T1 = new Trainer(CourseType.CSharp, "Hector", "Gkatsos");
            Trainer T2 = new Trainer(CourseType.Java, "Argyris", "Pagidas");
            Trainer T3 = new Trainer(CourseType.CSharp, "Ioannis", "Panagopoulos");
            Trainer T4 = new Trainer(CourseType.Java, "Mairy", "Soumi");
            Trainer T5 = new Trainer(CourseType.Java, "Trainer", "Train");
            Trainer T6 = new Trainer(CourseType.Java, "Dim", "Tsamis");
            Trainer T7 = new Trainer(CourseType.Java, "John", "Lask");
            Trainer T8 = new Trainer(CourseType.Java, "Kostas", "Xagorar");
            trainersDB.Add(T1);
            trainersDB.Add(T2);
            trainersDB.Add(T3);
            trainersDB.Add(T4);
            trainersDB.Add(T5);
            trainersDB.Add(T6);
            trainersDB.Add(T7);
            trainersDB.Add(T8);

            //Assignments DB
            Assignment AS1 = new Assignment("Assignent1", "C#/Java blablabla...", new DateTime(2019, 03, 31, 12, 0, 0));
            Assignment AS2 = new Assignment("Assignent2", "Java blablabla...", new DateTime(2019, 10, 31, 12, 0, 0));
            Assignment AS3 = new Assignment("Assignent3", "Python blablabla...", new DateTime(2019, 03, 31, 12, 0, 0));
            Assignment AS4 = new Assignment("Assignent4", "ASP blablabla...", new DateTime(2019, 10, 31, 12, 0, 0));
            Assignment AS5 = new Assignment("Assignent5", "JS blablabla...", new DateTime(2019, 03, 31, 12, 0, 0));
            Assignment AS6 = new Assignment("Assignent6", "HTML blablabla...", new DateTime(2019, 10, 31, 12, 0, 0));
            Assignment AS7 = new Assignment("Assignent6", "HTML blablabla...", new DateTime(2019, 10, 31, 12, 0, 0));
            Assignment AS8 = new Assignment("Assignent6", "HTML blablabla...", new DateTime(2019, 10, 31, 12, 0, 0));
            assignmentsDB.Add(AS1);
            assignmentsDB.Add(AS2);
            assignmentsDB.Add(AS3);
            assignmentsDB.Add(AS4);
            assignmentsDB.Add(AS5);
            assignmentsDB.Add(AS6);
            assignmentsDB.Add(AS7);
            assignmentsDB.Add(AS8);

            //Create Courses
            Course FoulTimeCSharp = new Course("Full Time C#", StreamType.FullTime, CourseType.CSharp, new DateTime(2019, 01, 01), new DateTime(2019, 03, 31));
            Course PartTimeCSharp = new Course("Part Time C#", StreamType.PartTime, CourseType.CSharp, new DateTime(2019, 04, 01), new DateTime(2019, 10, 31));
            Course FoulTimeJava = new Course("Full Time Java", StreamType.FullTime, CourseType.Java, new DateTime(2019, 01, 01), new DateTime(2019, 03, 31));
            Course PartTimeJava = new Course("Part Time Java", StreamType.PartTime, CourseType.Java, new DateTime(2019, 04, 01), new DateTime(2019, 10, 31));

            //List of Courses
            CB8.Add(FoulTimeCSharp);
            CB8.Add(PartTimeCSharp);
            CB8.Add(FoulTimeJava);
            CB8.Add(PartTimeJava);

            //Relate students to Course
            StudentsPerCourse CB81 = new StudentsPerCourse(FoulTimeCSharp, studentsDB.GetRange(0,3));
            StudentsPerCourse CB82 = new StudentsPerCourse(PartTimeCSharp, studentsDB.GetRange(3, 6));
            StudentsPerCourse CB83 = new StudentsPerCourse(FoulTimeJava, studentsDB.GetRange(4, 5));
            StudentsPerCourse CB84 = new StudentsPerCourse(PartTimeJava, studentsDB.GetRange(7, 3));
            studentsPerCourse.Add(CB81);
            studentsPerCourse.Add(CB82);
            studentsPerCourse.Add(CB83);
            studentsPerCourse.Add(CB84);

            //Relate Trainers to Courses
            TrainersPerCourse TPC1 = new TrainersPerCourse(FoulTimeCSharp, trainersDB.GetRange(0, 2));
            TrainersPerCourse TPC2 = new TrainersPerCourse(PartTimeCSharp, trainersDB.GetRange(2, 2));
            TrainersPerCourse TPC3 = new TrainersPerCourse(FoulTimeJava, trainersDB.GetRange(4, 2));
            TrainersPerCourse TPC4 = new TrainersPerCourse(PartTimeJava, trainersDB.GetRange(6, 2));
            trainersPerCourse.Add(TPC1);
            trainersPerCourse.Add(TPC2);
            trainersPerCourse.Add(TPC3);
            trainersPerCourse.Add(TPC4);

            //Relate Assignments to Courses
            AssignmentsPerCours APC1 = new AssignmentsPerCours(FoulTimeCSharp, assignmentsDB.GetRange(0, 2));
            AssignmentsPerCours APC2 = new AssignmentsPerCours(PartTimeCSharp, assignmentsDB.GetRange(2,2));
            AssignmentsPerCours APC3 = new AssignmentsPerCours(FoulTimeJava, assignmentsDB.GetRange(4, 2));
            AssignmentsPerCours APC4 = new AssignmentsPerCours(PartTimeJava, assignmentsDB.GetRange(6,2));
            assignmentsPerCourse.Add(APC1);
            assignmentsPerCourse.Add(APC2);
            assignmentsPerCourse.Add(APC3);
            assignmentsPerCourse.Add(APC4);

            //Relate Assigments to Students and Courses
            AssignmentPerCourseStudents APS1 = new AssignmentPerCourseStudents(S1, APC1);
            AssignmentPerCourseStudents APS2 = new AssignmentPerCourseStudents(S2, APC2);
            AssignmentPerCourseStudents APS3 = new AssignmentPerCourseStudents(S3, APC3);
            AssignmentPerCourseStudents APS4 = new AssignmentPerCourseStudents(S4, APC4);
            AssignmentPerCourseStudents APS5 = new AssignmentPerCourseStudents(S5, APC2);
            AssignmentPerCourseStudents APS6 = new AssignmentPerCourseStudents(S6, APC2);
            AssignmentPerCourseStudents APS7 = new AssignmentPerCourseStudents(S7, APC2);
            AssignmentPerCourseStudents APS8 = new AssignmentPerCourseStudents(S8, APC2);
            AssignmentPerCourseStudents APS9 = new AssignmentPerCourseStudents(S9, APC2);
            AssignmentPerCourseStudents APS10 = new AssignmentPerCourseStudents(S10, APC2);
            assignmentPerCourseStudents.Add(APS1);
            assignmentPerCourseStudents.Add(APS2);
            assignmentPerCourseStudents.Add(APS3);
            assignmentPerCourseStudents.Add(APS4);
            assignmentPerCourseStudents.Add(APS5);
            assignmentPerCourseStudents.Add(APS6);
            assignmentPerCourseStudents.Add(APS7);
            assignmentPerCourseStudents.Add(APS8);
            assignmentPerCourseStudents.Add(APS9);
            assignmentPerCourseStudents.Add(APS10);
        }
    }
}
