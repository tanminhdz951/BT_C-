
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
                Console.WriteLine("a[{0}] = ", i);
                Mang_236[i] = int.Parse(Console.ReadLine());
            }


        }
    }
}
