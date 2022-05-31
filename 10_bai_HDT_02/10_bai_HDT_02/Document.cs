using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_bai_HDT_02
{
    class Document
    {
        private int id_236;
        private String nxb_236;
        private int number_236;

        
        public string Nxb_236 { get => nxb_236; set => nxb_236 = value; }
        public int Number_236 { get => number_236; set => number_236 = value; }
        public int Id_236 { get => id_236; set => id_236 = value; }

        public Document()
        {

        }
        public Document(int id, String nxb, int number)
        {
            this.Id_236 = id;
            this.Nxb_236 = nxb;
            this.Number_236 = number;
        }

        public void input_document()
        {
            Console.Write("Nhap ma : ");
            Id_236 = int.Parse(Console.ReadLine());
            Console.Write("Nhap nha xuat ban: ");
            Nxb_236 = Console.ReadLine();
            Console.Write("Nhap so phat hanh: ");
            Number_236 = int.Parse(Console.ReadLine());
        }

        public void String()
        {
            Console.WriteLine("Ma: {0}  ", Id_236);
            Console.WriteLine("NXB: {0}", Nxb_236);
            Console.WriteLine("So ban phat hanh: {0}", Number_236);
        }
    }
}
