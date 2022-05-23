using System;

namespace LAB_01
{
    class Student
    {
        private int SID_236;
        private string TenSV_236;
        private string Khoa_236;
        private float DiemTB_236;
        public Student() //Constructor mac dinh
        {
            SID_2361 = 1;
            TenSV_2361 = "Nguyen Van Nam";
            Khoa_2361 = "CNTT";
            DiemTB_2361 = 7;
        }
        public Student(Student stu) //Constructor sao chep
        {
            SID_2361 = stu.SID_2361;
            TenSV_2361 = stu.TenSV_2361;
            Khoa_2361 = stu.Khoa_2361;
            DiemTB_2361 = stu.DiemTB_2361;
        }

        public int SID_2361 { get => SID_236; set => SID_236 = value; }
        public string TenSV_2361 { get => TenSV_236; set => TenSV_236 = value; }
        public string Khoa_2361 { get => Khoa_236; set => Khoa_236 = value; }
        public float DiemTB_2361 { get => DiemTB_236; set => DiemTB_236 = value; }

        public void Show()
        {
            Console.WriteLine("MSSV:{0}", this.SID_2361);
            Console.WriteLine("Ten SV:{0}", this.TenSV_2361);
            Console.WriteLine("Khoa:{0}", this.Khoa_2361);
            Console.WriteLine("Diem TB:{0}", this.DiemTB_2361);
        }

    }

    class Tester
    {
        public static void Nhap1SV(Student[] DSSV, int n)
        {
            for (int i = 0; i < n; i++)
            {
                DSSV[i] = new Student();
                Console.Write("Nhap MaSV {0}: ", i + 1);
                DSSV[i].SID_2361 = int.Parse(Console.ReadLine());
                Console.Write("Ho ten SV: ");
                DSSV[i].TenSV_2361 = Console.ReadLine();
                Console.Write("Nhap khoa: ");
                DSSV[i].Khoa_2361 = Console.ReadLine();
                Console.Write("Nhap Diem TB: ");
                DSSV[i].DiemTB_2361 = float.Parse(Console.ReadLine());
                Console.Write(Environment.NewLine);
            }
        }
        public static void XuatDS(Student[] DSSV)
        {
            foreach (Student sv in DSSV)
                sv.Show();
        }

        public static void Main()
        {
            Student[] DSSV;
            int n;
            Console.Write("Nhap so luong sinh vien: ");
            n = int.Parse(Console.ReadLine());
            DSSV = new Student[n];
            Console.WriteLine("\n === NHAP DANH SACH SINH VIEN ===");
            Nhap1SV(DSSV, n);
            Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            XuatDS(DSSV);
            Console.ReadLine();
        }
    }
}
