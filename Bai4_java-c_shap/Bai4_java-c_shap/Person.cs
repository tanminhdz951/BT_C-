using System;

namespace Bai4_java_c_shap
{
    class Person
    {
        private String name_236;
        private int age_236;
        private String job_236;
        private int passport_236;

        public Person()
        {

        }
        public Person(String name_236, int age_236, String job_236, int passport_236)
        {
            this.Name_236 = name_236;
            this.Age_236 = age_236;
            this.Job_236 = job_236;
            this.Passport_236 = passport_236;
        }

        public string Name_236 { get => name_236; set => name_236 = value; }
        public int Age_236 { get => age_236; set => age_236 = value; }
        public string Job_236 { get => job_236; set => job_236 = value; }
        public int Passport_236 { get => passport_236; set => passport_236 = value; }

        public void Input_person()
        {
            Console.Write("Nhap ho va ten : ");
            name_236 = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            age_236 = int.Parse(Console.ReadLine());
            Console.Write("Nhap nghe nghiep:  ");
            job_236 = Console.ReadLine();
            Console.Write("Nhap so cmnd: ");
            Passport_236 = int.Parse(Console.ReadLine());
        }

        public void ouput_person()
        {
            Console.WriteLine("Ho ten: {0}, Tuoi: {1}, Nghe nghiep: {2}, CMND: {3}", name_236, age_236, job_236, passport_236);
        }

    }

}
