using System;

namespace _10_bai_HDT_02
{
    class Program
    {

        static void Main(string[] args)
        {
            ManagerDocument managerDocument = new ManagerDocument();
            Console.WriteLine("Enter a: to insert Book");
            Console.WriteLine("Enter b: to insert Newspaper");
            Console.WriteLine("Enter c: to insert Journal");
            String type = Console.ReadLine();
            Console.ReadKey();
            Console.Write("Nhap ma : ");
            int Id_236 = int.Parse(Console.ReadLine());
            Console.Write("Nhap nha xuat ban: ");
            String Nxb_236 = Console.ReadLine();
            Console.Write("Nhap so phat hanh: ");
            int Number_236 = int.Parse(Console.ReadLine());
            switch (type)
            {
                case "a":
                    {
                        Console.Write("Nhap so phat hanh: ");
                        string author_236 =Console.ReadLine();
                        Console.Write("Nhap thang phat hanh: ");
                        int numberPage = int.Parse(Console.ReadLine());
                        Document book = new Book(Id_236, Nxb_236, Number_236, author_236,numberPage);
                        managerDocument.addDocument(book);
                        break;
                    }
                case "b":
                    {
                        Console.Write("Nhap thang phat hanh: ");
                        int dayIssue_236 = int.Parse(Console.ReadLine());
                        Document newspaper = new Newspaper(Id_236, Nxb_236, Number_236, dayIssue_236);
                        managerDocument.addDocument(newspaper);
                        break;
                    }
                case "c":
                    {
                        Console.Write("Nhap so phat hanh: ");
                        int issueNumber_236 = int.Parse(Console.ReadLine());
                        Console.Write("Nhap thang phat hanh: ");
                        int monthIssue_236 = int.Parse(Console.ReadLine());
                        Document journal = new Journal(Id_236, Nxb_236, Number_236, issueNumber_236, monthIssue_236);
                        managerDocument.addDocument(journal);
                        break;
                    }
                default:
                    break;
            }

            managerDocument.showInfor();
        }
    }
}
