using CardServicesU.Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardServicesU.Practice.CardType
{
    public sealed class CreditCard : Card
    {
        private double _cardLimit;
        public double CardLimit 
        {
            get { return _cardLimit; }
            set 
            {
                if (value < 0) Console.WriteLine("Kart limiti menfi ola bilmez!!!");
                else _cardLimit = value;
            }
        }
        public  override void Withdraw(double cash)
        {
            
            double residueBalance = cash - Balance;
            if(Balance - cash < 0) Console.WriteLine($"Kartinizda yeterli mebleg olmadigindan qaliq mebleg kredit kartinizdan chixildi. Debit kart balansiniz: 0.00, Kredit kart balansiniz: {CardLimit - residueBalance}");
            else Console.WriteLine($"Mebleg debit kart balansinizdan chixildi. Balansiniz: {Balance - cash}");
        }
    }
}


