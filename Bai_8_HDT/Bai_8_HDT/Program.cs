using System;

namespace Bai_8_HDT
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean tieptuc = true;
            ManagerCard managerCards = new ManagerCard();
            int chon;
            int n;
            Console.WriteLine("Nhap so luong the ban dau ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin the muon thu {0}", i + 1);
                Card card = new Card();
                card.Input_card();
                managerCards.add(card);
            }
            Console.Clear();

            while (tieptuc)
            {
                
                Console.WriteLine("*********** MENU **************");
                Console.WriteLine("1. Them the muon ");
                Console.WriteLine("2. Hien thi thong tin tat ca the muon ");
                Console.WriteLine("3. Xoa The muon ");
                Console.WriteLine("0. ket thuc chuong trinh ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.Clear();
                        Card card = new Card();
                        card.Input_card();
                        managerCards.add(card);
                        Console.WriteLine("*********** Them the muon thanh cong **************");
                        break;
                    case 2:
                        Console.Clear();
                        managerCards.Output_list_card();
                        break;
                    case 3:
                        Console.Clear();
                        int id_xoa;
                        Console.Write("Nhap id the can xoa: ");
                        id_xoa = int.Parse(Console.ReadLine());
                        managerCards.delete_card(id_xoa);
                        break;
                    case 0:
                        Console.WriteLine("********Chuong Trinh da ket thuc******** ");
                        tieptuc = false;
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
