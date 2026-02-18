using CardServicesU.Practice.CardType;
using CardServicesU.Practice.Extension_Methods;
using CardServicesU.Practice.ICardServices;
using CardServicesU.Practice.Models;

namespace CardServicesU.Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            DebitCard debitCard1 = new DebitCard(1, 500, "4167738815874525", Enum.Banks.ABB);
            DebitCard debitCard2 = new DebitCard(1, 500, "4167738815874526", Enum.Banks.ABB);
            DebitCard debitCard3 = new DebitCard(1, 500, "4167738815874527", Enum.Banks.Kapital);
            DebitCard debitCard4 = new DebitCard(1, 500, "4167738815874528", Enum.Banks.Kapital);
            DebitCard debitCard5 = new DebitCard(1, 500, "4167738815874529", Enum.Banks.Leo);

            CreditCard creditCard1 = new CreditCard(1, 500, "4167738815874520", Enum.Banks.Leo, 500);
            CreditCard creditCard2 = new CreditCard(1, 500, "4167738815874521", Enum.Banks.Leo, 500);
            CreditCard creditCard3 = new CreditCard(1, 500, "4167738815874522", Enum.Banks.ABB, 500);
            CreditCard creditCard4 = new CreditCard(1, 500, "4167738815874523", Enum.Banks.Kapital, 500);
            CreditCard creditCard5 = new CreditCard(1, 500, "41677388158745294", Enum.Banks.Leo, 500);



            // kart elave etme sistemi
            CardService cardService = new CardService();
            cardService.AddCardToList(debitCard1);
            cardService.AddCardToList(debitCard2);
            cardService.AddCardToList(debitCard3);
            cardService.AddCardToList(debitCard4);
            cardService.AddCardToList(debitCard5);

            cardService.AddCardToList(creditCard1);
            cardService.AddCardToList(creditCard2);
            cardService.AddCardToList(creditCard3);
            cardService.AddCardToList(creditCard4);
            cardService.AddCardToList(creditCard5);

            creditCard4.ExpenseBonuses(10);

            // kart nomresi uzre axtaris:
            Card search = cardService["4167738815874529"];
            
            // butun kartlari gosteren metod
            cardService.ShowAllCard();

            
        }
    }
}
