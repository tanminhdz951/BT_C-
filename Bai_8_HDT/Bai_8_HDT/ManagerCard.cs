using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_8_HDT
{
    class ManagerCard
    {
        private List<Card> cards = new List<Card>();

        public ManagerCard(List<Card> cards)
        {
            this.cards = cards;
        }
        public ManagerCard()
        {
           
        }
        public void add(Card card)
        {
            this.cards.Add(card);

        }

        public void Output_list_card()
        {
            Console.WriteLine("*********** Thong tin tat ca the muon **************");
            int i = 1;
            foreach (Card card in cards)
            {
                Console.WriteLine("Thong tin the muon thu {0}",i);
                card.Ouput_card();
                Console.WriteLine("");
                i++;
            }

        }
        public void delete_card(int item)
        {
            int xn = 0;
            foreach(Card card in cards)
            {
                if(card.id == item)
                {
                    cards.Remove(card);
                    Console.WriteLine("Da xoa the thanh cong");
                    xn = 1;
                    break;
                }
            }
            if(xn ==0)
            {
                Console.WriteLine("Khong tim thay id the muon can xoa");
            }  
        }
    }
}
