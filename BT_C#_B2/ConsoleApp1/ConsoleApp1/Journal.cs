using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_HDT_B2
{
    class Journal : Document
    {
        private int issueNumber;
        private int monthIssue;
        public Journal(string Id, string nxb, int number, int issueNumber, int monthIssue)
       : base(Id, nxb, number)
        {
            this.IssueNumber = issueNumber;
            this.MonthIssue = monthIssue;
        }

        public int IssueNumber { get => issueNumber; set => issueNumber = value; }
        public int MonthIssue { get => monthIssue; set => monthIssue = value; }
    }
}