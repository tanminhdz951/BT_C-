using System;

namespace Bai_9_HDT
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean tieptuc = true;
            ManagerBienLai managerBienLai = new ManagerBienLai();
            int chon;
            int n;
            Console.WriteLine("Nhap so luong bien lai ban dau ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin the muon thu {0}", i + 1);
                BienLai bienlai = new BienLai();
                bienlai.Input_Bienlai();
                managerBienLai.add(bienlai);
            }
            Console.Clear();

            while (tieptuc)
            {

                Console.WriteLine("*********** MENU **************");
                Console.WriteLine("1. Them bien lai ");
                Console.WriteLine("2. Hien thi thong tin tat ca bien lai ");
                Console.WriteLine("3. Xoa bien lai ");
                Console.WriteLine("3. Sua bien lai ");
                Console.WriteLine("0. ket thuc chuong trinh ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.Clear();
                        BienLai bienlai = new BienLai();
                        bienlai.Input_Bienlai();
                        managerBienLai.add(bienlai);
                        Console.WriteLine("*********** Them bien lai thanh cong **************");
                        break;
                    case 2:
                        Console.Clear();
                        managerBienLai.Hien_Thi_thong_tin();
                        break;
                    case 3:
                        Console.Clear();
                         String name_xoa;
                        Console.Write("Nhap ten chu ho  can xoa: ");
                        name_xoa = Console.ReadLine();
                        managerBienLai.delete_bienlai(name_xoa);
                        break;
                    case 4:
                        Console.Clear();
                        String name_sua;
                        Console.Write("Nhap ten chu ho  can sua: ");
                        name_sua = Console.ReadLine();
                        managerBienLai.update_bienlai(name_sua);
                        break;
                    case 0:
                        Console.WriteLine("********Chuong Trinh da ket thuc******** ");
                        tieptuc = false;
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}