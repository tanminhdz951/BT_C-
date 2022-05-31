using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_bai_HDT_02
{
    class Newspaper:Document
    {
        private int dayIssue_236;
        private Document document_236 = new Document();
        public Newspaper(int Id_236, string Nxb_236, int Number_236, int dayIssue)
        : base(Id_236, Nxb_236, Number_236)
        {
            this.DayIssue_236 = dayIssue;
        }
        public Newspaper()
        {

        }
        public int DayIssue_236 { get => dayIssue_236; set => dayIssue_236 = value; }
        internal Document Document_236 { get => document_236; set => document_236 = value; }

        public void output()
        {
            Console.WriteLine("Ma: {0}  ", Id_236);
            Console.WriteLine("NXB: {0}", Nxb_236);
            Console.WriteLine("So ban phat hanh: {0}", Number_236);
            Console.WriteLine("Tac gia : {0}  ", DayIssue_236);
            
        }
    }
}
