using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinh_da_hinh
{
    class HinhVuong:DaGiac
    {
        int canh = 4;
        public HinhVuong(int canh)
        : base(canh)
        {
            Console.WriteLine("Hinh vuong là hinh co {0} canh bang nhau và co 4 goc vuong", canh);
        }
    }
}
