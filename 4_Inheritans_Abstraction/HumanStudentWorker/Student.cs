using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Invalid faculty number (5-10" + @" letters/digits) ");
                }

                this.facultyNumber = value;
            }
        }
    }
}
