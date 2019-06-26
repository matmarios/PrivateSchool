using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace DataBase
{
    class DB
    {

        Course FoulTimeCSharp = new Course("Foul Time C#", StreamType.FullTime, CourseType.CSharp, new DateTime(2019, 01, 01), new DateTime(2019, 03, 31));
        Course PartTimeCSharp = new Course("Part Time C#", StreamType.PartTime, CourseType.CSharp, new DateTime(2019, 04, 01), new DateTime(2019, 10, 31));
        Course FoulTimeJava = new Course("Foul Time Java", StreamType.FullTime, CourseType.Java, new DateTime(2019, 01, 01), new DateTime(2019, 03, 31));
        Course PartTimeJava = new Course("Part Time Java", StreamType.PartTime, CourseType.Java, new DateTime(2019, 04, 01), new DateTime(2019, 10, 31));
        public DB()
        {
            Course FoulTimeCSharp = new Course("Foul Time C#", StreamType.FullTime, CourseType.CSharp, new DateTime(2019, 01, 01), new DateTime(2019, 03, 31));
        }
    }
}
