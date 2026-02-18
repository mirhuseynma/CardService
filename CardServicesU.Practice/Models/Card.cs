using CardServicesU.Practice.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardServicesU.Practice.Models
{
    public abstract class Card
    {
        public int Id { get; set; }
        public double Balance { get; set; }
        public double Bonus { get; set; }
        private string _cardNumber;
        public Banks Bank { get; set; }
        public string CardNumber 
        {
            get { return _cardNumber; }
            set 
            { 
                bool checkLetter = false;
                if (value.Length > 16 && value.Length < 16) Console.WriteLine("Kart nomresi 16 reqem olmalidir!!!");
                else _cardNumber = value;
                for(int i = 0; i<value.Length; i++)
                {
                    if (char.IsLetter(value[i]) == true)
                    {
                        Console.WriteLine("Kart nomresi yalniz reqemden ibaret olmalidir!!!");
                        return;
                    }
                    else _cardNumber = value;
                }
                _cardNumber = value.Replace(" ", "");

            }
        }

        public Card(int id, double balance, string cardNumber, Banks bank)
        {
            Id = id;
            Balance = balance;
            CardNumber = cardNumber;
            Bank = bank;
        }
        public abstract void Withdraw(double cash);
        
    }
}
