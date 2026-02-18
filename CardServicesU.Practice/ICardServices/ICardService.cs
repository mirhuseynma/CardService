using CardServicesU.Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardServicesU.Practice.ICardServices
{
    public interface ICardService
    {
        public void AddCardToList(Card card);
        Card this[string cardNumber] { get; }
    }
}
