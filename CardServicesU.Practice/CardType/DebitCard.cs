using CardServicesU.Practice.Enum;
using CardServicesU.Practice.Extension_Methods;
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
        public DebitCard(int id, double balance, string cardNumber,Banks bank) : base(id, balance, cardNumber ,bank)
        {
        }

        public override void Withdraw(double cash)
        {
            if(cash>Balance) Console.WriteLine($"daxil etdiyiniz mebleg balansinizdan boyuk olduguna gore emeliyat ugursuz oldu. Balansiniz: {Balance}");     
            else Console.WriteLine($"{cash} meblegide eskinaz kartinizdan cixildi. Qalan balans: {Balance-cash}");
            
        }

        public override string ToString()
        {
            return $"Balans: {Balance}, Kart nomresi: {CardNumber.MaskCardNumber()}, istifade etdiyiniz bank: {Bank}";
        }
    }
}
