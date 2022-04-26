using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIEMDANH_26_4
{
    class PT_bac2
    {
        int a_236, b_236, c_236;

        public PT_bac2(int a_236, int b_236, int c_236)
        {
            this.a_236 = a_236;
            this.b_236 = b_236;
            this.c_236 = c_236;
        }

        public int A_236 { get => a_236; set => a_236 = value; }
        public int B_236 { get => b_236; set => b_236 = value; }
        public int C_236 { get => c_236; set => c_236 = value; }

        public double delta(int a_236, int b_236, int c_236)
        {
            double delta;
            delta = (b_236 * b_236) - (4 * a_236 * c_236);
            return delta;
        }

        public void tinh_nghiem()
        {
            double nghiem_1, nghiem_2;
            double d;
            d = delta(a_236, b_236,c_236);
            if (d < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            if(d == 0)
            {
                nghiem_1 = -b_236 / (2 * a_236);
                Console.WriteLine("Phuong trinh co nghiem kep la {0}", nghiem_1);
            }

            if (d > 0)
            {
                nghiem_1 = (-b_236 + Math.Sqrt(d)) / (2 * a_236);
                nghiem_2 = (-b_236 - Math.Sqrt(d)) / (2 * a_236);
                Console.WriteLine("Phuong trinh co 2nghiem x1 = {0} x2 =  {1}", nghiem_1, nghiem_2);
            }

        }

    }
}
