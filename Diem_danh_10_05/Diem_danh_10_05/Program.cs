
using System;

namespace Diem_danh_10_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Mang_236 = new int[10];

            Console.WriteLine("Moi nhap gia tri");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("a[{0}] = ", i);
                Mang_236[i] = int.Parse(Console.ReadLine());
            }
            int max = 0;
            for (int i = 0; i < 10; i++)
            {
                if( Mang_236[i] > max)
                {
                    max = Mang_236[i];
                }  
            }

            int min = 100000000;

            for (int i = 0; i < 10; i++)
            {
                if (Mang_236[i] < min)
                {
                    min = Mang_236[i];
                }
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("a[{0}] = {1}",i, Mang_236[i]);
            }


        }
    }
}
