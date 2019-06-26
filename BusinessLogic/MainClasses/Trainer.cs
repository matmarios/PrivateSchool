using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.MainClasses
{
    class Trainer
    {
        private CourseType _subject;

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public Trainer(CourseType subject, string firstName, string lastName)
        {
            _subject = subject;
            _firstName = firstName;
            _lastName = lastName;
        }

        public override string ToString()
        {
            return String.Format($"{FirstName} {LastName} subject {_subject.ToString()}");
        }
    }
}
