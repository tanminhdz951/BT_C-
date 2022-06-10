using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_8_HDT
{
    class Student
    {
        private String name { get; set; }
        private int age { get; set; }
        private String school { get; set; }

        public Student(String name, int age, String school)
        {
            this.name = name;
            this.age = age;
            this.school = school;
        }

        public Student()
        {
        }
        public void Input_student()
        {
            Console.WriteLine("Nhap thong tin sinh vien muon the");
            Console.Write("Nhap ho ten: ");
            name = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Nhap que quan: ");
            school = Console.ReadLine();

        }
        public void Output_student()
        {
            Console.WriteLine("Thong tin sinh vien");
            Console.WriteLine("Ho ten:{0} ",name);
            Console.WriteLine("Tuoi:{0} " ,age);
            Console.WriteLine("Que quan: {0}" ,school);
        }

    }
}
