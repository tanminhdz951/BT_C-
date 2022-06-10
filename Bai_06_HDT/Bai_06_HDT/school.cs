using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_06_HDT
{
    class school
    {
        private List<student> students = new List<student>();



        public school(List<student> students)
        {
            this.students = students;
        }
        public school()
        {
           
        }

        public void add(student student)
        {
            students.Add(student);
        }

        public void Ouout_list_students()
        {
            Console.WriteLine("*********** Thong tin hoc sinh la **************");
            int i = 1;
            foreach (student student in students)
            {
                Console.WriteLine("Thong tin sinh vien thu {0} la:",i);
                student.Output_student();
                i++;
            }
        }

        public void Ouput_students_20years()
        {
            Console.WriteLine("*********** Thong tin hoc sinh la tren 20 tuoi **************");
            int i = 1;
            foreach (student student in students)
            {
                if (student.age > 20)
                {
                    Console.WriteLine("Thong tin sinh vien thu {0} la:", i);
                    student.Output_student();
                    i++;
                }
                
            }
        }

        public void countStudent_23YearOld_InDN()
        {
            int count = 0;
            
            foreach (student student in students)
            {
                if (student.age > 23 && student.hometown.Equals("DN"))
                {
                    count++;
                }
            }
            Console.WriteLine("So Luong sinh vien tren 20 tuoi va que o DN la {0}", count);
        }

    }
}
