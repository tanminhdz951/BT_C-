using System;

namespace LAB_01
{
    class Student
    {
        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;
        public Student() //Constructor mac dinh
        {
            SID1 = 1;
            TenSV1 = "Nguyen Van Nam";
            Khoa1 = "CNTT"; 
            DiemTB1 = 7;
        }
        public Student(Student stu) //Constructor sao chep
        {
            SID1 = stu.SID1;
            TenSV1 = stu.TenSV1;
            Khoa1 = stu.Khoa1;
            DiemTB1 = stu.DiemTB1;
        }

        public int SID1 { get => SID; set => SID = value; }
        public string TenSV1 { get => TenSV; set => TenSV = value; }
        public string Khoa1 { get => Khoa; set => Khoa = value; }
        public float DiemTB1 { get => DiemTB; set => DiemTB = value; }

        public void Show()
        {
            Console.WriteLine("MSSV:{0}", this.SID);
            Console.WriteLine("Ten SV:{0}", this.TenSV);
            Console.WriteLine("Khoa:{0}", this.Khoa);
            Console.WriteLine("Diem TB:{0}", this.DiemTB);
        }

    }

    class Tester{public static void Main()
    {
        Student[] DSSV; int n; 
            Console.Write("Nhap so luong SV:"); 
            n = int.Parse(Console.ReadLine()); 
            DSSV = new Student[n]; 
            //tao mang n phan tu
            Console.WriteLine("\n ====NHAP DS SINH VIEN====");
            for(int i = 0; i < n; i++) 
             //Lap n lan nhap thong tinsv
             {
                DSSV[i] = new Student();
                Console.Write("Nhap MaSV {0}:",i+1);
                DSSV[i].SID1 = int.Parse(Console.ReadLine());
                Console.Write("Ho ten SV:");
                DSSV[i].TenSV1 = Console.ReadLine();
                Console.Write("Nhap khoa:");
                DSSV[i].Khoa1 = Console.ReadLine();
                Console.Write("Nhap Diem TB:");
                DSSV[i].DiemTB1 = float.Parse(Console.ReadLine());
            }
            //Xuat DS Sinh vien
                Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            foreach(Student sv in DSSV)
                sv.Show();
            Console.ReadLine();
        }
    }
}
