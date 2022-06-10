using System;
using System.Collections.Generic;

namespace Bai_06_HDT
{
    class Program
    {
        static void Main(string[] args)
        {
            school school = new school();
            Console.WriteLine("Nhap so luong hoc sinh");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin hoc sinh thu {0}", i + 1);
                student student = new student();
                student.Input_student();
                school.add(student);
            }

            school.Ouout_list_students();
            school.Ouput_students_20years();
            school.countStudent_23YearOld_InDN();
        }
    }
}
