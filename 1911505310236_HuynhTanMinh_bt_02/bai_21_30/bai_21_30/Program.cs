using System;

namespace bai_21_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int chonso_236;
            do
            {
                Console.WriteLine("Moi chon bai toan");
                Console.WriteLine("22. Dem va tinh tong cac uoc so.");
                Console.WriteLine("23. tim so hoan hao be hon mot so cho truoc.");
                Console.WriteLine("0. ket thuc chuong trinh");

                chonso_236 = int.Parse(Console.ReadLine());
                Console.ReadKey();
                if(chonso_236 == 22)
                {
                    int so_236;
                    Console.Write("Nhap so: = ");
                    so_236 = int.Parse(Console.ReadLine());
                    int tong = 0;
                    int sl = 0;
                    Console.Write("Cac uoc so la: ");
                    for ( int i=1; i<= so_236; i++)
                    {
                        if(so_236 % i == 0)
                        {
                            Console.Write(" {0}",i );
                            sl = sl + 1;
                            tong = tong +i;
                        }
                    }
                    Console.WriteLine("\nCo {0} va co tong la {1}", sl, tong);
                }
                if (chonso_236 == 23)
                {
                    int so_236;
                    Console.Write("Nhap so: = ");
                    so_236 = int.Parse(Console.ReadLine());
                    Console.Write("Cac so hoan hao be hon {0} la :", so_236);
                    for (int i = 1; i <so_236; i++)
                    {
                        int tong = 0;
                        for (int j = 1; j < i; j++)
                        {
                            if (i % j == 0)
                            {
                                tong = tong + j;
                                
                            }
                        }
                        if(tong == i)
                        {
                            Console.Write(" {0}", i);
                        }
                    }
                    Console.Write("\n");

                }
            } while (chonso_236 != 0);
            Console.Clear(); // Xóa màn hình
            Console.WriteLine("Hen giap lại!");
        }
    }
}
