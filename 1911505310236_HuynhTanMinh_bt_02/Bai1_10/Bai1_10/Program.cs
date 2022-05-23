using System;

namespace Bai1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int chonso_236;
            do
            {
                Console.WriteLine("Moi chon bai:");
                Console.WriteLine("Bai 1: Tinh the tich hinh cau:");
                Console.WriteLine("Bai 2: Tinh khoang cach 2 diem A va B");
                Console.WriteLine("Bai 6: In 3 so theo thu tu tang dan :");
                Console.WriteLine("Bai 7: Giai phuong trinh bac 1 :");
                Console.WriteLine("0. ket thuc chuong trinh");
                chonso_236 = int.Parse(Console.ReadLine());
                Console.ReadKey();

            if(chonso_236 == 1)
                {
                    double S_236, R_236, V_236;
                    double Pi = 3.141593;
                    Console.WriteLine("Bai 1: Tinh the tich hinh cau:");
                    Console.WriteLine("Moi nhap dien tich cua hinh cau:");
                    Console.Write("a = ");
                    S_236 = double.Parse(Console.ReadLine());
                    R_236 = Math.Sqrt(S_236 / (4 * Pi));

                    V_236 = 4.0 / 3 * Pi * R_236 * R_236 * R_236;
                    Console.WriteLine("The tich cua hinh cau do la: {0}", V_236);
                }
            if (chonso_236 == 2)
                {
                    double Xa, Ya, Xb, Yb, d;
                    Console.WriteLine("Bai 2: Tinh khoang cach 2 diem A va B");
                    Console.WriteLine("Moi nhap toa do diem A:");
                    Console.Write("Xa = ");
                    Xa = double.Parse(Console.ReadLine());
                    Console.Write("Xb = ");
                    Ya = double.Parse(Console.ReadLine());
                    Console.WriteLine("Moi nhap toa do diem B:");
                    Console.Write("Xb = ");
                    Xb = double.Parse(Console.ReadLine());
                    Console.Write("Yb = ");
                    Yb = double.Parse(Console.ReadLine());
                    d = Math.Sqrt(Math.Pow((Xb - Xa),2) + Math.Pow((Yb - Ya), 2));
                   
                    Console.WriteLine("Khoang cach gia A({0} {1}) va B({2}, {3}) la: {4}",Xa, Ya, Xb, Yb, d );
                }

            if(chonso_236 == 6)
                {
                    int so1_236, so2_236, so3_236;
                    Console.WriteLine("Bai 6: In 3 so theo thu tu tang dan :");
                    Console.Write("Moi nhap so thu 1: ");
                    so1_236 = int.Parse(Console.ReadLine());
                    Console.Write("Moi nhap so thu 2: ");
                    so2_236 = int.Parse(Console.ReadLine());
                    Console.Write("Moi nhap so thu 3: ");
                    so3_236 = int.Parse(Console.ReadLine());

                    int max = so1_236;
                    if(so1_236 > so2_236 && so1_236 > so3_236)
                    {
                        if (so2_236 > so3_236)
                        {
                            Console.WriteLine("Tang dan: {0} {1} {2}", so3_236, so2_236, so1_236);
                        }
                        else
                        {
                            Console.WriteLine("Tang dan: {0} {1} {2}", so2_236, so3_236, so1_236);
                        }     
                    }

                    if (so2_236 > so1_236 && so1_236 > so3_236)
                    {
                        if (so1_236 > so3_236)
                        {
                            Console.WriteLine("Tang dan: {0} {1} {2}", so3_236, so1_236, so2_236);
                        }
                        else
                        {
                            Console.WriteLine("Tang dan: {0} {1} {2}", so1_236, so3_236, so2_236);
                        }
                    }

                    if (so3_236 > so2_236 && so3_236 > so1_236)
                    {
                        if (so2_236 > so1_236)
                        {
                            Console.WriteLine("Tang dan: {0} {1} {2}", so1_236, so2_236, so3_236);
                        }
                        else
                        {
                            Console.WriteLine("Tang dan: {0} {1} {2}", so2_236, so1_236, so3_236);
                        }
                    }

                }

                if (chonso_236 == 7)
                {
                    double a_236, b_236, kt_236;
                    Console.WriteLine("Bai 6: In 3 so theo thu tu tang dan :");
                    Console.Write("Moi he so di voi x: ");
                    a_236 = int.Parse(Console.ReadLine());
                    Console.Write("Moi nhap he so tu do: ");
                    b_236 = int.Parse(Console.ReadLine());
                    kt_236 = b_236 / a_236;
                    Console.WriteLine("Gia tri cua x la : {0}", kt_236);

                }


            } while (chonso_236 != 0);
            Console.Clear(); // Xóa màn hình
            Console.WriteLine("Hen giap lại!");

            }
    }
}
