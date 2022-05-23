using System;

namespace Bai_10_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int chonso_236;
            do
            {
                Console.WriteLine("Moi chon bai toan");
                Console.WriteLine("18. Nhap so gio va in ra so tuong duong theo tuan ngay gio.");
                Console.WriteLine("19. Nhap vao thoi diem 1 va in. in ra khong thoi gian giua chung.");
                Console.WriteLine("20. Tinh KW da tieu thu.");
                Console.WriteLine("0. ket thuc chuong trinh");

                chonso_236 = int.Parse(Console.ReadLine());
                Console.ReadKey();

            if(chonso_236 == 18)
                {
                    Console.Clear(); // Xóa màn hình
                    int sogio_236, tuan_236, ngay_236, gio_236;
                    Console.WriteLine("In ra tuan ngay gio");
                    Console.Write("Nhap so gio:  = ");
                    sogio_236 = int.Parse(Console.ReadLine());

                    tuan_236 = sogio_236 / 168;
                    ngay_236 = (sogio_236 % 168) / 24;
                    gio_236 = (sogio_236 % 168) % 24;
                    Console.WriteLine("{0} tuan {1} ngay {2} gio",tuan_236,ngay_236, gio_236);
                }

                if (chonso_236 == 19)
                {
                    int h1_236, p1_236, s1_236, h2_236, p2_236, s2_236;
                    long time, time1, time2;
                    Console.WriteLine("Tính time giua 2 thoi diem");
                    Console.Write("Nhap gio phut giay [1]:  = ");
                    h1_236 = int.Parse(Console.ReadLine());
                    p1_236 = int.Parse(Console.ReadLine());
                    s1_236 = int.Parse(Console.ReadLine());
                    time1 = h1_236 * 3600 + p1_236 * 60 + s1_236;
                    Console.Write("Nhap gio phut giay [2]:  = ");
                    h2_236 = int.Parse(Console.ReadLine());
                    p2_236 = int.Parse(Console.ReadLine());
                    s2_236 = int.Parse(Console.ReadLine());
                    time2 = h2_236 * 3600 + p2_236 * 60 + s2_236;

                    time = time1 - time2;
                    if (time < 0)
                        time = -time;
                    Console.WriteLine("Tính time giua 2 thoi diem la {0} h {1} phut {2} giay", 
                        time/3600, (time % 3600)/60, (time % 3600) % 60);

                }

                if (chonso_236 == 20)
                {
                    int kw_236, money_236;
                    Console.WriteLine("Tính tien dien");
                    Console.Write("Nhap so kw: = ");
                    kw_236 = int.Parse(Console.ReadLine());
                    money_236 = kw_236 * 500;
                    if( kw_236> 100)
                    {
                        money_236 = money_236 + (kw_236 - 100) * 300;
                    }
                    if (kw_236 > 250)
                    {
                        money_236 = money_236 + (kw_236 - 250) * 200;
                    }
                    if (kw_236 > 350)
                    {
                        money_236 = money_236 + (kw_236 - 350) * 500;
                    }

                    Console.WriteLine("Gia tien dien la : {0}",money_236);


                }

            } while(chonso_236 != 0);
            Console.Clear(); // Xóa màn hình
            Console.WriteLine("Hen giap lại!");
        }
    }
}
