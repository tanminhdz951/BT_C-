using System;

namespace _1911505310236_HuynhTanMinh_BaiKiemTra1
{
    class Program
    {
        static void Main(string[] args)
        {
            int chonso_36;
            do
            {
                Console.WriteLine("Moi chon bai:");
                Console.WriteLine("Bai 1: Viet Phuong thuc in ra tong hieu tich phuong cua 2 so duoc nhap vao.");
                Console.WriteLine("Bai 2: Tinh khoang cach 2 diem A va B");
                Console.WriteLine("Bai 3: Viet phuong thuc nhap vao 1 so thap phan in ra so nhi phan.");
                Console.WriteLine("Bai 4: Viet Phuong thuc in ra thong tin ho ten , lop, maSV.:");
                Console.WriteLine("0. ket thuc chuong trinh");
                chonso_36 = int.Parse(Console.ReadLine());

                if(chonso_36 == 1)
                {
                    Console.WriteLine("Bai 1: Viet Phuong thuc in ra tong hieu tich phuong cua 2 so duoc nhap vao.");
                    double so1_36, so2_36;
                    Console.Write("Nhap so thu 1 = ");
                    so1_36 = double.Parse(Console.ReadLine());
                    Console.Write("Nhap so thu 2 = ");
                    so2_36 = double.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("Tong = {0}", so1_36 + so2_36);
                    Console.WriteLine("Hieu = {0}", so1_36 - so2_36);
                    Console.WriteLine("Tich = {0}", so1_36 * so2_36);
                    double thuong_36 = so1_36 / so2_36;
                    Console.WriteLine("Thuong  = {0}",thuong_36);
                }
                if(chonso_36 == 2)
                {
                    Console.WriteLine("===============================================");
                    Console.WriteLine("===============================================");
                    Console.WriteLine("=======================*=======================");
                    Console.WriteLine("======================***======================");
                    Console.WriteLine("=====================*****=====================");
                    Console.WriteLine("====================*******====================");
                    Console.WriteLine("===================*********===================");
                    Console.WriteLine("==================***********==================");
                    Console.WriteLine("=========*****************************=========");
                    Console.WriteLine("==========***************************==========");
                    Console.WriteLine("===========*************************===========");
                    Console.WriteLine("============***********************============");
                    Console.WriteLine("=============*********************=============");
                    Console.WriteLine("==============*******************=============");
                    Console.WriteLine("===============*****************==============");
                    Console.WriteLine("================***************===============");
                    Console.WriteLine("=================*************================");
                    Console.WriteLine("==================***********=================");
                    Console.WriteLine("=================*************================");
                    Console.WriteLine("================***************===============");
                    Console.WriteLine("===============****************===============");
                    Console.WriteLine("==============******************==============");
                    Console.WriteLine("=============**********=*********=============");
                    Console.WriteLine("============**********===*********============");
                    Console.WriteLine("===========*********=======*********==========");
                    Console.WriteLine("==========********===========********=========");
                    Console.WriteLine("========********===============*******========");
                    Console.WriteLine("=======*******===================*******======");
                    Console.WriteLine("======******=======================******=====");
                    Console.WriteLine("=====*****===========================*****====");
                    Console.WriteLine("====****===============================****===");
                    Console.WriteLine("===***===================================***===");
                    Console.WriteLine("==*=========================================*==");
                    Console.WriteLine("===============================================");


                }
                if (chonso_36 == 3)
                {
                    Console.WriteLine("Bai 3: Viet phuong thuc nhap vao 1 so thap phan in ra so nhi phan.");
                    int so_36;
                    Console.Write("Moi nhap so: ");
                    so_36 = int.Parse(Console.ReadLine());
                    int i_36;
                    int[] Array_36 = new int[10];
                    for (i_36 = 0; so_36 > 0; i_36++)
                    {
                        Array_36[i_36] = so_36 % 2;
                        so_36 = so_36 / 2;
                    }
                    Console.Write("So thap phan sau khi chuyen doi: ");
                    for (i_36 = i_36 - 1; i_36 >= 0; i_36--)
                    {
                        Console.Write(Array_36[i_36]);
                    }
                    Console.WriteLine();

                }
                if(chonso_36 == 4)
                {
                    Console.WriteLine("Bai 4: Viet Phuong thuc in ra thong tin ho ten , lop, maSV.:");
                    string hoten_36, lop_36, maSV_36;
                    Console.Write("Moi Nhap ho ten: ");
                    hoten_36 = Console.ReadLine();
                    Console.Write("Moi Nhap lop: ");
                    lop_36 = Console.ReadLine();
                    Console.Write("Moi Nhap maSV: ");
                    maSV_36 = Console.ReadLine();

                    Console.WriteLine("=======Thong tin sinh vien la :============");
                    Console.WriteLine("Ho va ten: {0}",hoten_36);
                    Console.WriteLine("Lop: {0}", lop_36);
                    Console.WriteLine("Ma sinh vien: {0}", maSV_36);

                }

            } while (chonso_36 != 0);
            Console.Clear(); // Xóa màn hình
            Console.WriteLine("Hen giap lại!");

        }
    }
}
