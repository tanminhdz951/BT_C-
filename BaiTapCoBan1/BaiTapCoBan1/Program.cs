using System;

namespace BaiTapCoBan1
{
    class Program
    {
        static void Main(string[] args)
        {
            int chonso_236;
            do
            {
                Console.WriteLine("Moi chon bai toan");
                Console.WriteLine("1. Nhap vao va kiem tra so do am hay duong.");
                Console.WriteLine("2. Nha vao va in ra chu cua so do.");
                Console.WriteLine("3. Nhap 3 canh va kiem tra do co phai la tam giac khong.");
                Console.WriteLine("4. Nhap vao 3 canh va kiem tra do co phai la tam giac vuong.");
                Console.WriteLine("0. ket thuc chuong trinh");

                chonso_236 = int.Parse(Console.ReadLine());
                Console.ReadKey();

                if (chonso_236 == 1)
                {
                    int so_236;
                    Console.Clear(); // Xóa màn hình
                    Console.WriteLine("Moi ban nhap mot so bat ki");
                    so_236 = int.Parse(Console.ReadLine());
                    if (so_236 > 0)
                    {
                        Console.WriteLine("Day la so nguyen duong");
                    }
                    else
                    {
                        Console.WriteLine("Day la so nguyen am");
                    }

                }

                if (chonso_236 == 2)
                {
                    int so_236;
                    Console.Clear(); // Xóa màn hình
                    Console.WriteLine("Moi Nhap mot so tu 1 den 9");
                    so_236 = int.Parse(Console.ReadLine());
                    switch (so_236)
                    {
                        case 1:
                            {
                                Console.WriteLine(" Mot ");
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine(" Hai ");
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine(" Ba ");
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine(" Bon ");
                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine(" Nam ");
                                break;
                            }
                        case 6:
                            {
                                Console.WriteLine(" Sau ");
                                break;
                            }
                        case 7:
                            {
                                Console.WriteLine(" Bay ");
                                break;
                            }
                        case 8:
                            {
                                Console.WriteLine(" Tam ");
                                break;
                            }
                        case 9:
                            {
                                Console.WriteLine(" Chin ");
                                break;
                            }
                    }
                }
                if(chonso_236 == 3)
                {
                    Console.Clear(); // Xóa màn hình
                    float a_236, b_236, c_236;
                    Console.WriteLine("Moi nhap 3 canh cua tam giac:");
                    Console.Write("a = ");
                    a_236 = float.Parse(Console.ReadLine());

                    Console.Write("b = ");
                    b_236 = float.Parse(Console.ReadLine());

                    Console.Write("c = ");
                    c_236 = float.Parse(Console.ReadLine());

                    if (a_236 < b_236 + c_236 && b_236 < a_236 + c_236 && c_236 < a_236 + b_236)
                    {
                        Console.WriteLine("Ba canh {0}, {1}, {2}  la ba canh cua mot tam giac", a_236,b_236,c_236);
                    }
                    else
                        Console.WriteLine("Ba canh a, b, c khong phai la ba canh cua mot tam giac");

                }

                if (chonso_236 == 4)
                {
                    Console.Clear(); // Xóa màn hình
                    float a_236, b_236, c_236;
                    Console.WriteLine("Moi nhap 3 canh cua tam giac:");
                    Console.Write("a = ");
                    a_236 = float.Parse(Console.ReadLine());

                    Console.Write("b = ");
                    b_236 = float.Parse(Console.ReadLine());

                    Console.Write("c = ");
                    c_236 = float.Parse(Console.ReadLine());

                    if (a_236 * a_236 == b_236 * b_236 + c_236 * c_236 || b_236 * b_236 == a_236 * a_236 + c_236 * c_236 || c_236 * c_236 == a_236 * a_236 + b_236 * b_236)
                    {
                        Console.WriteLine("Ba canh {0}, {1}, {2}  la ba canh cua mot tam giac vuong", a_236, b_236, c_236);
                    }
                    else
                        Console.WriteLine("Ba canh {0}, {1}, {2}  khong phai la ba canh cua mot tam giac vuong", a_236, b_236, c_236);

                }
            } while (chonso_236 != 0);
            Console.Clear(); // Xóa màn hình
            Console.WriteLine("Hen giap lại!");
            }
    }
}
