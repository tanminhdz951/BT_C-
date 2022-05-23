using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_java_c_shap
{
    class Family : Person
    {
        
        private Person[] persons_236 = new Person[20];
        private int address_236;
        private int amout_236;      

        public int Address_236 { get => address_236; set => address_236 = value; }
        public int Amout_236 { get => amout_236; set => amout_236 = value; }
        internal Person[] Presons_236 { get => persons_236; set => persons_236 = value; }

        public Family()
        {

        }
        public Family(int amout, int address, Person[] person)
        {
            this.address_236 = address;
            this.amout_236 = amout;
            this.persons_236 = person;
        }

        public void Input_Family()
        {
            Console.Write("Nhap so thanh vien: ");
            amout_236 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nha: ");
            address_236 = int.Parse(Console.ReadLine());
            for (int i_236 = 1; i_236 <= amout_236; i_236++)
            {
                Console.WriteLine("Nhap thong tin thanh vien thu " + i_236);
                persons_236[i_236] = new Person();
                persons_236[i_236].Input_person();
            }
        }
        public void Output_family()
        {
            Console.WriteLine("So thanh vien: {0}, So nha: {1}", amout_236, address_236);
            for (int i_236 = 1; i_236 <= amout_236; i_236++)
            {
                Console.WriteLine("Thanh vien thu " + i_236);
                persons_236[i_236].ouput_person();
            }
        }

    }
}
