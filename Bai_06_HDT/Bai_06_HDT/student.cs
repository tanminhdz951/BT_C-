using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_06_HDT
{
    class student
    {
        public String name { get; set; }
        public int age { get; set; }
        public String hometown { get; set; }
       

        public student(String name, int age, String hometown)
        {
            this.name = name;
            this.age = age;
            this.hometown = hometown;
        }

        public student()
        {
        }
        public void Input_student()
        {
            Console.Write("Nhap ho ten: ");
            name = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Nhap que quan: ");
            hometown = Console.ReadLine();
            
        }
        public void Output_student()
        {
            Console.WriteLine("Ho ten: " + name);
            Console.WriteLine("Tuoi: " + age);
            Console.WriteLine("Que quan: " + hometown);
        }

    }
}
