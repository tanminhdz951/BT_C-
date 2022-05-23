using System;

namespace BT_mang
{
    class Program
    {
        static void Main(string[] args)
        {
            int chonso_236;
            do
            {
                Console.WriteLine("Moi chon bai toan");
                Console.WriteLine("58. In ra cac so nguyen to nho hon so n da cho  ");
                Console.WriteLine("59. Chuyen nam duong lich sang am lich ");
                Console.WriteLine("60. ");
                Console.WriteLine("61. ");
                Console.WriteLine("62. ");
                Console.WriteLine("63. ");
                Console.WriteLine("64. ");
                Console.WriteLine("0. ket thuc chuong trinh");

                chonso_236 = int.Parse(Console.ReadLine());
                Console.ReadKey();

                int isPrimeNumber(int n)
                {
                    // so nguyen n < 2 khong phai la so nguyen to
                    if (n < 2)
                    {
                        return 0;
                    }
                    // check so nguyen to khi n >= 2
                    int i;
                    int squareRoot = (int)Math.Sqrt(n);
                    for (i = 2; i <= squareRoot; i++)
                    {
                        if (n % i == 0)
                        {
                            return 0;
                        }
                    }
                    return 1;
                }

                if (chonso_236 == 58)
                {
                    Console.Clear(); // Xóa màn hình
                    int n;
                    Console.Write("Moi nhap so n : ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Tat ca cac so nguyen to nho hon {0} la: ", n);
                    if (n >= 2)
                    {
                        Console.Write("{0} ", 2);
                    }
                    for (int i = 3; i < n; i += 2)
                    {
                        if (isPrimeNumber(i) == 1)
                        {
                            Console.Write("{0} ", i);
                        }
                    }
                    Console.WriteLine("");
                }

                if (chonso_236 == 59)
                {
                    Console.Clear(); // Xóa màn hình
                    int namduong;
                    string[] can = new string[] { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };
                    string[] chi = new string[] { "Than", "Dau", "Tuat", "Hoi", "Ti", "Suu", "Dan", "Meo", "Thin", "Ty", "Ngo", "Mui" };

                    Console.Write("Moi nhap vao nam duong lich: ");
                    namduong = int.Parse(Console.ReadLine());
                    Console.WriteLine("{0} la nam {1} {2}", namduong, can[namduong % 10], chi[namduong % 12]);
                    Console.WriteLine("{0} la nam {1} {2}", namduong + 60, can[namduong % 10], chi[namduong % 12]);
                }
                if (chonso_236 == 60)
                {

                    int so, n;
                    Random rd = new Random();

                    do
                    {
                        Console.Write("Moi nhap so chan: ");
                        n = int.Parse(Console.ReadLine());
                    } while (n % 2 != 0);
                    int[] mang = new int[n];
                    int[] mang2 = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        so = rd.Next(-100, 100);
                        mang[i] = so;
                    }
                    Console.WriteLine("Gia tri cua mang la: ");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("{0} ", mang[i]);
                    }

                    Console.WriteLine();

                }
                if (chonso_236 == 61)
                {
                    Console.Clear(); // Xóa màn hình
                    int so, n;
                    Random rd = new Random();
                    int sum = 0;
                    Console.Write("Moi nhap so phan tu: ");
                    n = int.Parse(Console.ReadLine());
                    int[] mang = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        so = rd.Next(-100, 100);
                        mang[i] = so;
                    }
                    Console.Write("Gia tri cua mang la: ");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("{0} ", mang[i]);
                        if (mang[i] > 0)
                        {
                            sum += mang[i];
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Tong cac so chan la :{0}", sum);

                    Console.Write("moi nhap vi tri can xoa: ");
                    int p = int.Parse(Console.ReadLine());
                    for (int i = p; i < n - 1; i++)
                    {
                        mang[i] = mang[i + 1];
                    }

                    for (int i = 0; i < n - 1; i++)
                    {
                        Console.Write("{0} ", mang[i]);
                    }
                    Console.WriteLine();
                }

                if (chonso_236 == 62)
                {
                    Console.Clear();
                    int so, n;
                    Random rd = new Random();
                    int tonglevtchan = 0, tongchanvtle = 0;

                    Console.Write("Moi n [1 99] ");
                    n = int.Parse(Console.ReadLine());

                    int[] mang = new int[n];
                    int[] mang2 = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        so = rd.Next(10, 20);
                        mang[i] = so;
                    }
                    Console.WriteLine("Gia tri cua mang la: ");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("{0} ", mang[i]);
                    }
                    Console.WriteLine();

                    for (int i = 0; i < n; i = i + 2)
                    {
                        if (mang[i] % 2 != 0)
                        {
                            tonglevtchan += mang[i];
                        }
                    }
                    for (int i = 1; i < n; i = i + 2)
                    {
                        if (mang[i] % 2 == 0)
                        {
                            tongchanvtle += mang[i];
                        }
                    }

                    if (tongchanvtle == tonglevtchan)
                    {
                        Console.WriteLine("Tong le o vi tri chan bang tong chan o vi tri le = {0}", tonglevtchan);
                    }
                    else
                    {
                        Console.WriteLine("Tong Le vi tri chan ({0}) khac tong chan  o vi tri le ({1})", tonglevtchan, tongchanvtle);
                    }
                    Console.WriteLine();

                }

                if (chonso_236 == 63)
                {
                    int so, n;
                    int count = 0;
                    Random rd = new Random();
                    Console.Write("Moi nhap so phan tu: ");
                    n = int.Parse(Console.ReadLine());
                    int[] mang = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        so = rd.Next(-100, 100);
                        mang[i] = so;
                    }
                    Console.WriteLine("Gia tri cua mang la: ");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("{0} ", mang[i]);
                        if (mang[i] % 4 == 0 && (mang[i] %10 == 6 || mang[i] % 10 == -6))
                        {
                            count += 1;
                        }
                        if (mang[i] % 2 != 0)
                        {
                            mang[i] *= 2;
                        }
                    }

                    Console.Write("\nSo phan tu chia het cho 4 va tan cung bang 6 la :{0} ",count);
                    Console.WriteLine("\nMang sau khi thay doi cac gia trị le");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("{0} ", mang[i]);
                    }
                    Console.WriteLine("");

                    }

                if (chonso_236 == 64)
                {
                    int so, n;
                    int count = 0;
                    Random rd = new Random();
                    Console.Write("Nhap n[1 99]: ");
                    n = int.Parse(Console.ReadLine());
                    int[] mang = new int[n];
                    for( int i = 0; i<n; i++)
                    {
                        Console.Write("Nhap phan tu thu {0} :", i);
                        mang[i] = int.Parse(Console.ReadLine());
                    }

                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(" {0}",mang[i]);
                    }
                }
            } while (chonso_236 != 0);
            Console.Clear(); // Xóa màn hình
            Console.WriteLine("Hen giap lại!");




        }
    }
}

