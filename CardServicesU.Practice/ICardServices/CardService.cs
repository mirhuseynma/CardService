using CardServicesU.Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardServicesU.Practice.ICardServices
{
    public class CardService : ICardService
    {
        private Card[] _cards = new Card[50];
        private int _count = 0;
        

        public Card this[string cardNumber]
        {
            get
            {
                for(int i = 0; i < _count; i++)
                {
                    if (_cards[i].CardNumber == cardNumber) {
                        Console.WriteLine(_cards[i].ToString());
                        return _cards[i]; 
                    }
                }
                return null;
            }
        }

        public void AddCardToList(Card newCard)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_cards[i].CardNumber == newCard.CardNumber) 
                {
                    Console.WriteLine("Bu kart artiq sistemde movcuddur");
                    return;
                } 
            }
            _cards[_count] = newCard;
            _count++;
        }

        public void ShowAllCard()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine($"{i + 1}. {_cards[i]}");
            }
        }
    }
}
