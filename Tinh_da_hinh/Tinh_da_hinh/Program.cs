using System;

namespace Tinh_da_hinh
{
    class Program
    {
        static void Main(string[] args)
        {
            int chonso_236;
            Console.WriteLine("Moi nhap hinh can chon:");
            Console.WriteLine("1 Hinh vuong" );
            Console.WriteLine("2 Hinh Tam Giac ");
            Console.WriteLine("3 Hinh Tu giac");


            chonso_236 = int.Parse(Console.ReadLine());
            Console.ReadKey();

            if (chonso_236 == 1) {
                HinhVuong h1 = new HinhVuong(4);
            }

            if (chonso_236 == 2)
            {
                Tamgiac h1 = new Tamgiac(4);
            }

            if (chonso_236 == 4)
            {
                TuGiac h1 = new TuGiac(4);
            }


        }
    }
}
