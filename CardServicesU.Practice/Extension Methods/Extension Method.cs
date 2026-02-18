using CardServicesU.Practice.CardType;
using CardServicesU.Practice.Enum;
using CardServicesU.Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace CardServicesU.Practice.Extension_Methods
{
    public static class Extension_Method
    {
        public static string MaskCardNumber(this string cardNumber)
        {
            if (string.IsNullOrEmpty(cardNumber) == true && cardNumber.Length != 16)
            {
                Console.WriteLine("Kart nomresi yanlish daxil edilib");
            }
            string firstFourLetter = cardNumber.Substring(0, 4);
            string secondFourLetter = cardNumber.Substring(12, 4);
            return $"{firstFourLetter} **** **** {secondFourLetter}";
        }

        public static string ExpenseBonuses(this Card card, double cash)
        {
            if(card.Balance > cash)
            {
                double bonusPercent;
                switch (card.Bank)
                {
                    case Enum.Banks.ABB:
                        bonusPercent = 0.02;
                        break;
                    case Enum.Banks.Leo:
                        bonusPercent = 0.04;
                        break;
                    case Enum.Banks.Kapital:
                        bonusPercent = 0.05;
                        break;
                    default:
                        bonusPercent = 0.01;
                        break;
                }
                double earnedBonus = bonusPercent * cash;
                card.Bonus += earnedBonus;
                Console.WriteLine($"{cash} AZN meblegindeki odenish ugurla heyata kecirildi.");
                Console.WriteLine($"{card.Bank} terefinfen {earnedBonus} AZN bonus qazandiniz. Cari bonusunuz: {card.Bonus}");

            }
            return "Yetersiz vesait";
        }
    }
}
