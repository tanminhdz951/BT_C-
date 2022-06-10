using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_8_HDT
{
    class Card
    {
        public int id { get; set; }
        public int borrowDate { get; set; }
        public int paymentDate { get; set; }
        public int bookId { get; set; }
        public Student student = new Student();

        public Card(Student student, int id, int borrowDate, int paymentDate, int bookId)
        {
            this.student = student;
            this.id = id;
            this.borrowDate = borrowDate;
            this.paymentDate = paymentDate;
            this.bookId = bookId;
        }
        public Card() { }

        public void Input_card()
        {
            Console.WriteLine("Nhap thong tin the muon");
            Console.Write("Nhap id the : ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Nhap id sach: ");
            bookId = int.Parse(Console.ReadLine());
            Console.Write("Nhap ngay muon: ");
            borrowDate = int.Parse(Console.ReadLine());
            Console.Write("Nhap ngay tra: ");
            paymentDate = int.Parse(Console.ReadLine());
            student.Input_student();       
        }
        public void Ouput_card()
        {
            Console.WriteLine("id the :{0} ",id);
            Console.WriteLine("id sach:{0} ",bookId);
            Console.WriteLine("ngay muon:{0} ",borrowDate);
            Console.WriteLine("ngay tra:{0} ",paymentDate);
            student.Output_student();
        }

    }
}
