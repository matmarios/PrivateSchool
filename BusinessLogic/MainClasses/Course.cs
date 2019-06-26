using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.MainClasses
{
    class Course
    {
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private StreamType _stream;

        public StreamType Stream
        {
            get { return _stream; }
            set { _stream = value; }
        }

        private CourseType _type;

        public CourseType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private DateTime _start_date;

        public DateTime StartDate
        {
            get { return _start_date; }
            set { _start_date = value; }
        }

        private DateTime _end_date;

        public DateTime EndDate
        {
            get { return _end_date; }
            set { _end_date = value; }
        }


        public List<Assignment> Assigments { get; set; }

        public Course(string title, StreamType streamType, CourseType type, DateTime startDate, DateTime endDate)
        {
            _title = title;
            _stream = streamType;
            _type = type;
            _start_date = startDate;
            _end_date = endDate;
            Assigments = new List<Assignment>();
        }

        public override string ToString()
        {
            return String.Format($"Course: {_title} {_stream} {_type} starts on {_start_date.ToShortDateString()} and ends on {_end_date.ToShortDateString()}"); 
        }
    }
}
