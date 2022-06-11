using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_9_HDT
{
    class ManagerBienLai
    {
        public List<BienLai> bienlais = new List<BienLai>();

        public ManagerBienLai(List<BienLai> bienLais)
        {
            this.bienlais = bienlais;
        }
        public ManagerBienLai()
        {

        }

        public void add(BienLai student)
        {
            bienlais.Add(student);
        }

        public void Hien_Thi_thong_tin()
        {
            Console.WriteLine("*********** Thong tin tat ca bien lai **************");
            int i = 1;
            foreach ( BienLai bienLai in bienlais)
            {
                Console.WriteLine("Thong tin bien lai thu {0} la:", i);
                i++;
                bienLai.Output_BienLai();
            }
        }

        public void delete_bienlai(string item)
        {
            int xn = 0;
            foreach (BienLai bienLai in bienlais)
            {
                if (bienLai.kh.name.Equals(item))
                {
                    bienlais.Remove(bienLai);
                    Console.WriteLine("Da xoa bien lai thanh cong");
                    xn = 1;
                    break;
                }
            }
            if (xn == 0)
            {
                Console.WriteLine("Khong tim thay ten chu ho can xoa");
            }
        }

        public void update_bienlai(string item)
        {
            int xn = 0;
            foreach (BienLai bienLai in bienlais)
            {
                if (bienLai.kh.name.Equals(item))
                {
                    bienLai.Output_BienLai();
                    Console.WriteLine("*********** Nhap thong tin can sua **************");
                    Console.WriteLine("Luu y: Nêu khong thay doi thong tin nao vui long an dien -1 đe bo qua thong tin do ");
                    Console.Write("Nhap so nha: ");
                    int sonha = int.Parse(Console.ReadLine());
                    Console.Write("Nhap ma so cong to dien: ");
                    int maSCTD = int.Parse(Console.ReadLine());
                    Console.Write("Nhap chi so cu: ");
                    int CSC = Int32.Parse(Console.ReadLine());
                    Console.Write("Nhap chi so moi: ");
                    int CSM = Int32.Parse(Console.ReadLine());

                    if(sonha != -1)
                    {
                        bienLai.kh.sonha = sonha;
                    }
                    if (maSCTD != -1)
                    {
                        bienLai.kh.maSCTD = sonha;
                    }
                    if (CSC != -1)
                    {
                        bienLai.CSC = CSC;
                    }
                    if (CSM != -1)
                    {
                        bienLai.CSM = CSM;
                    }

                    double Tientra = bienLai.TienTra(bienLai.CSC, bienLai.CSM);
                    Console.WriteLine("Da cap nhap bien lai thanh cong");
                    xn = 1;
                    break;
                }
            }
            if (xn == 0)
            {
                Console.WriteLine("Khong tim thay ten chu ho can xoa");
            }
        }
    }
}
