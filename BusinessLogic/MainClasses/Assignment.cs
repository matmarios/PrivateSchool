using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.MainClasses
{
    class Assignment
    {
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private DateTime _subDateTime;

        public DateTime SubDateTime
        {
            get { return _subDateTime; }
            set { _subDateTime = value; }
        }

        private double _oralMark;

        public double OralMark
        {
            get { return _oralMark; }
            set { _oralMark = value; }
        }

        private double _totalMark;

        public double TotalMark
        {
            get { return _oralMark; }
            set { _oralMark = value; }
        }

        public Assignment(string title, string description, DateTime subDate)
        {
            Title = title;
            Description = description;
            SubDateTime = subDate;
        }

        public Assignment(string title, string description, DateTime subDate, double oralMark, double totalMark)
        {
            Title = title;
            Description = description;
            SubDateTime = subDate;
            OralMark = oralMark;
            TotalMark = totalMark;
        }

        public override string ToString()
        {
            return String.Format($"Title: {Title}, Description: {Description}, Submition Date: {SubDateTime}, OralMark: {OralMark} and the total Mark is: {TotalMark}");
        }
    }
}
