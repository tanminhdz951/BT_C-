using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_9_HDT
{
    class KhachHang
    {
        public String name { get; set; }
        public int sonha { get; set; }
        public int maSCTD { get; set; }

        public KhachHang(string name , int sonha, int maSCTD)
        {
            this.name = name;
            this.sonha = sonha;
            this.maSCTD = maSCTD;
        }
        public KhachHang()
        {

        }

        public void Input_KH()
        {
            Console.Write("Nhap ho ten: ");
            name = Console.ReadLine();
            Console.Write("Nhap so nha: ");
            sonha = int.Parse(Console.ReadLine());
            Console.Write("Nhap ma so cong to dien: ");
            maSCTD = int.Parse(Console.ReadLine());
        }

        public void Output_KH()
        {
            Console.WriteLine("Ho ten: {0}" ,name);
            Console.WriteLine("So nha:{0} " , sonha);
            Console.WriteLine("Ma so CTD: {0} " ,maSCTD);
        }
    }
    
}
