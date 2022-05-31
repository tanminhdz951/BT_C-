using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_bai_HDT_02
{
    class Book: Document
    {
        private String author_236;
        private int numerPage_236;
        

        public string Author_236 { get => author_236; set => author_236 = value; }
        public int NumerPage_236 { get => numerPage_236; set => numerPage_236 = value; }

        public Book()
        {

        }
        public Book(int Id_236, string Nxb_236, int Number_236, string author, int numberPage)
        : base(Id_236, Nxb_236, Number_236)
        {
            this.Author_236 = author;
            this.NumerPage_236 = numberPage;
        }


        public void ouput()
        {
            Console.WriteLine("Ma: {0}  ", Id_236);
            Console.WriteLine("NXB: {0}", Nxb_236);
            Console.WriteLine("So ban phat hanh: {0}", Number_236);
            Console.WriteLine("Tac gia : {0}  ", Author_236);
            Console.WriteLine("So trang: {0}", NumerPage_236);
        }
    }
}
