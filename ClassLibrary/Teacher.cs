using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Teacher:Person
    {
        protected string Position {  get; set; }
        protected string Chair { get; set; }
        protected string University {  get; set; }
        public Teacher()
        {
            Position = "Teacher";
            Chair = "ICT";
            University = "ZSTU";
        }
        public Teacher(string lastName, string firstName, DateOnly birthday, string position, string chair, string university)
            :base(lastName, firstName, birthday)
        {
            if (position == "" || chair == "" || university == "")
                throw new Exception("Incorrectly entered data");
            Position = position;
            Chair = chair;
            University = university;
        }
        public override string ShowInfo()
        {
            return $"{base.ShowInfo()} {University} {Chair} {Position}";
        }
    }
}
