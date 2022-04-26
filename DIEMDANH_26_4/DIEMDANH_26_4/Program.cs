using System;

namespace DIEMDANH_26_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a_236, b_236, c_236;
            Console.WriteLine("Moi nhap so");
            Console.Write("a = ");
            a_236 = Int32.Parse(Console.ReadLine());
            Console.Write("b = ");
            b_236 = Int32.Parse(Console.ReadLine());
            Console.Write("c = ");
            c_236 = Int32.Parse(Console.ReadLine());
            Console.ReadKey();
            PT_bac2 pt_b2 = new PT_bac2(a_236, b_236, c_236);
            pt_b2.tinh_nghiem();

        }
    }
}
