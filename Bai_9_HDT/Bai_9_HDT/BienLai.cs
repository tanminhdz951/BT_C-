using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_9_HDT
{
    class BienLai
    {
        public KhachHang kh = new KhachHang();
        public int CSM { get; set; }
        public int CSC { get; set; }
        public double SoTien { get; set; }

        public BienLai()
        {

        }

        public BienLai(KhachHang kh, int chiSoCu, int chiSoMoi, double tienTra)
        {
            this.kh = kh;
            this.CSC = chiSoCu;
            this.CSC = chiSoMoi;
            this.SoTien = tienTra;
        }

        public void Input_Bienlai()
        {
            kh.Input_KH();
            Console.Write("Nhap chi so cu: ");
            CSC = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap chi so moi: ");
            CSM = Int32.Parse(Console.ReadLine());
            SoTien = TienTra(CSC, CSM);
        }

        public double TienTra(int a, int b)
        {
            return (b - a) * 5;
        }

        public void Output_BienLai()
        {
            kh.Output_KH();
            Console.WriteLine("Chi so cu: {0}" , CSC);
            Console.WriteLine("Chi so moi: {0}" , CSM);
            Console.WriteLine("So tien phai tra: {0}" , SoTien);
        }



    }
}
