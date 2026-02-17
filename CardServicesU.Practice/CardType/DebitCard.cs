using CardServicesU.Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardServicesU.Practice.CardType
{
    public sealed class DebitCard : Card
    {
        public DebitCard(int id, double balance, string cardNumber) : base(id, balance, cardNumber)
        {
        }

        public override void Withdraw(double cash)
        {
            if(cash>Balance) Console.WriteLine($"daxil etdiyiniz mebleg balansinizdan boyuk olduguna gore emeliyat ugursuz oldu. Balansiniz: {Balance}");
            else if (cash < 1) Console.WriteLine("cixarmaq istediyiniz mebleg 1 den ashagi olmamalidir!!");      
            else Console.WriteLine($"{cash} meblegide eskinaz kartinizdan cixildi. Qalan balans: {Balance-cash}");
        }

        public override string ToString()
        {
            return $"Balans: {Balance}, Kart nomresi: {CardNumber}";
        }
    }
}
