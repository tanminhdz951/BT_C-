using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bai4_java_c_shap
{
    
    class Town : Family
    {
        private Family[] Families_236 = new Family[100];
        private int quantity_Famyli_236;

       
        public int Quantity_Famyli_236 { get => quantity_Famyli_236; set => quantity_Famyli_236 = value; }
        internal Family[] Families_2361 { get => Families_236; set => Families_236 = value; }

        public Town()
        {
        }

        public Town(int quantity_Famyli_236, Family[] Families_236)
        {
            this.Quantity_Famyli_236 = quantity_Famyli_236;
            this.Families_2361 = Families_236;
        }
        public void Input_Town()
        {
            Console.WriteLine("Nhap so ho gia dinh: ");
            Quantity_Famyli_236 = int.Parse(Console.ReadLine());
            for (int i_236 = 1; i_236 <= Quantity_Famyli_236; i_236++)
            {
                Console.WriteLine("Nhap thong tin ho gia dinh thu " + i_236);
                Families_236[i_236] = new Family();
                Families_236[i_236].Input_Family();
            }  
        }

        public void Output_Town()
        {
            Console.WriteLine("Thong tin tat ca ho gia dinh: ");
            for (int i_236 = 1; i_236 <= quantity_Famyli_236; i_236++)
            {
                Console.WriteLine("Ho gia dinh thu " + i_236);
                Families_236[i_236].Output_family();
            }
        }
    }
}
