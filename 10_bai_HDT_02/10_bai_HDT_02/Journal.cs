using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_bai_HDT_02
{
    class Journal:Document
    {
        
        private int issueNumber_236;
        private int monthIssue_236;

       
        public int IssueNumber_236 { get => issueNumber_236; set => issueNumber_236 = value; }
        public int MonthIssue_236 { get => monthIssue_236; set => monthIssue_236 = value; }
        public Journal(int Id_236, string Nxb_236, int Number_236, int issueNumber, int monthIssue)
        : base(Id_236, Nxb_236, Number_236)
        {

            this.IssueNumber_236 = issueNumber;
            this.MonthIssue_236 = monthIssue;
        }
        public Journal()
        {

        }

        public void input_journal()
        {   
            Console.Write("Nhap so phat hanh: ");
            issueNumber_236 = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang phat hanh: ");
            monthIssue_236 = int.Parse(Console.ReadLine());
            
        }

        public void output()
        {
            Console.WriteLine("Ma: {0}  ", Id_236);
            Console.WriteLine("NXB: {0}", Nxb_236);
            Console.WriteLine("So ban phat hanh: {0}", Number_236);
            Console.WriteLine("So phat hanh: {0}  ",IssueNumber_236);
            Console.WriteLine("Thang phat hanh: {0}", MonthIssue_236);
        }
    }
}
