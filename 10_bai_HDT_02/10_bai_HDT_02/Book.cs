using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_bai_HDT_02
{
    class Book: Document
    {
        private String author;
        private int numerPage;
        public Book(string Id, string nxb, int number, string author, int numberPage)
        : base(Id, nxb, number)
        {
            this.Author = author;
            this.NumerPage = NumerPage;
        }

        public string Author { get => author; set => author = value; }
        public int NumerPage { get => numerPage; set => numerPage = value; }
    }
}
