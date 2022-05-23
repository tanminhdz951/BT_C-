using System;

namespace Bai_31_50
{
    class Program
    {
        static void Main(string[] args)
        {
            int chonso_236;
            do
            {
                Console.WriteLine("Moi chon bai toan");
                Console.WriteLine("35. kiem tra 1 so co phai so nguyen to. neu khong thi in ra so nguyen t gan nhat nho hon.");
                Console.WriteLine("36: In ra n so nguyen to .");
                Console.WriteLine("0. ket thuc chuong trinh");

                chonso_236 = int.Parse(Console.ReadLine());
                Console.ReadKey();
                if (chonso_236 == 35)
                {
                    int so_236;
                    Console.Write("Nhap so: = ");
                    int bien_nt = 0;
                    so_236 = int.Parse(Console.ReadLine());
                    for(int i =2; i < Math.Sqrt(so_236); i++)
                    {
                        if(so_236 % i == 0)
                        {
                            bien_nt = 1;
                        }
                    }
                    if(bien_nt == 1)
                    {
                        int b = 0;
                        int k = 0;
                        Console.WriteLine(" {0} khong phai la so nguyen to",so_236);
                        for (int i = 2; i < so_236; i++)
                        {
                            k = 0;
                            for (int j =2; j < i; j++)
                            {
                                if(i % j == 0)
                                {
                                    k = k+1;
                                }
                                if(k == 0 )
                                {
                                    b = i;
                                }
                            }
                        }
                        Console.WriteLine("so nguyen to be hon gan nhat {0} ", b);
                    }
                    else
                    {
                        Console.WriteLine(" {0}  la so nguyen to", so_236);
                    }
                  
                }
                if (chonso_236 == 36)
                {
                    int so_236;
                    Console.Write("Nhap so: = ");
                    int k = 0;
                    so_236 = int.Parse(Console.ReadLine());
                    Console.Write("{0} so nguyen to dau tien ", so_236);
                    int kt_nt = 0;
                    int dung = 2;
                    int kt = 0;
                    while (kt_nt < so_236)
                    {
                        kt = 0;
                        for (int i = 2; i < dung; i++)
                        {
                            if (dung % i == 0)
                            {
                                kt = kt + 1;
                            }
                        }
                        if (kt == 0)
                        {
                            Console.Write(" {0}", dung);
                            kt_nt += 1;
                        }
                        dung = dung + 1;
                    }
                    Console.Write("\n");

                }
            } while (chonso_236 != 0);
            Console.Clear(); // Xóa màn hình
            Console.WriteLine("Hen giap lại!");
        }
    }
}
