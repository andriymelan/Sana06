using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public  class Student:Person
    {
        protected int Course {  get; set; }
        protected string Group {  get; set; }
        protected string Faculty {  get; set; }
        protected string University { get; set; }
        public Student()
        {
            Course = 1;
            Group = "IPZ-20-1";
            Faculty = "ICT";
            University = "ZSTU";
        }
        public Student(string lastName, string firstName, DateOnly birthday, int course, string group, string faculty, string university)
            :base(lastName, firstName, birthday)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            University = university;
        }
        public override string ShowInfo()
        {
            return $"{base.ShowInfo()} {Course} {Group} {Faculty} {University}";
        }
    }
}
