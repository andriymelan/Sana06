using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Entrant:Person
    {
        protected int ZNO_Points {  get; set; }
        protected double EducationPoints { get; set; }
        protected string Institution {  get; set; }
        public Entrant()
        {
            ZNO_Points = 100;
            EducationPoints = 4;
            Institution = "lyceum #1 of Zhytomyr";
        }
        public Entrant(string lastName, string firstName, DateOnly birthday, int zNO_Points, double educationPoints, string institution)
            :base(lastName, firstName, birthday)
        {
            if (200<zNO_Points || 100<ZNO_Points  || 12<educationPoints || educationPoints<1||institution=="")
                throw new Exception("Incorrectly entered data");
            ZNO_Points = zNO_Points;
            EducationPoints = educationPoints;
            Institution = institution;
        }
        public override string ShowInfo()
        {
            return $"{base.ShowInfo()} {Institution} {ZNO_Points} {EducationPoints}";
        }
    }
}
