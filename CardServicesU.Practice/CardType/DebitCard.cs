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
        

        public override void Withdraw(double cash)
        {
            if (cash <1) Console.WriteLine("cixarmaq istediyiniz mebleg 1 den ashagi olmamalidir!!");
            else Console.WriteLine($"{cash} meblegide eskinaz kartinizdan cixildi. Qalan balans: {Balance-cash}");
        }
    }
}
