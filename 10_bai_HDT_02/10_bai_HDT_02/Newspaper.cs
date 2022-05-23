using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_bai_HDT_02
{
    class Newspaper:Document
    {
        private int dayIssue;
        public Newspaper(string Id, string nxb, int number, int dayIssue)
        : base(Id, nxb, number)
        {
            this.DayIssue = dayIssue;
        }

        public int DayIssue { get => dayIssue; set => dayIssue = value; }
    }
}
