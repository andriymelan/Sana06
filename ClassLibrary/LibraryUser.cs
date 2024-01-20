using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LibraryUser:Person
    {
        protected int TicketNumber { get; set; }
        protected DateOnly IssuanceDate {  get; set; }
        protected double MonthContribution {  get; set; }
        public LibraryUser()
        {
            TicketNumber = 100000;
            IssuanceDate = new DateOnly(2000,1,1);
            MonthContribution = 0;
        }
        public LibraryUser(string lastName, string firstName, DateOnly birthday, int ticketNumber, DateOnly issuanceDate, double monthContribution)
            :base(lastName, firstName, birthday)
        {
            if (ticketNumber < 0 || monthContribution < 0)
                throw new Exception("Incorrectly entered data");
            TicketNumber = ticketNumber;
            IssuanceDate = issuanceDate;
            MonthContribution = monthContribution;
        }
        public override string ShowInfo()
        {
            return $"{base.ShowInfo()} {TicketNumber} {IssuanceDate} {MonthContribution}";
        }
    }
}
