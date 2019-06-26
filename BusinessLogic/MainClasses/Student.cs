using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.MainClasses
{
    class Student
    {
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

        private DateTime _dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        private decimal _tuitionFees;

        public decimal Fees
        {
            get { return _tuitionFees; }
            set { _tuitionFees = value; }
        }

        public Student(string firstName, string lastName, DateTime dateOfBirth, decimal fees)
        {
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
            _tuitionFees = fees;
        }

        public override string ToString()
        {
            return String.Format($"{FirstName} {LastName} {DateOfBirth.ToShortDateString()}");
        }
    }
}
