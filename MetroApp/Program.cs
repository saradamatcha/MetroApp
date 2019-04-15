using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroApp
{
    class Program
    {

        static void Main(string[] args)
        {

              CardList listCards = new CardList();
            listCards.AddCard(new CardInfo() { CardId = 1001, Balance = 100.00});
            listCards.AddCard(new CardInfo() { CardId = 1002, Balance = 100.00});
            listCards.AddCard(new CardInfo() { CardId = 1003, Balance = 100.00});
            listCards.AddCard(new CardInfo() { CardId = 1004, Balance = 100.00});
            listCards.AddCard(new CardInfo() { CardId = 1005, Balance = 100.00});
            listCards.AddCard(new CardInfo() { CardId = 1006, Balance = 100.00});
            listCards.AddCard(new CardInfo() { CardId = 1007, Balance = 100.00});
            listCards.AddCard(new CardInfo() { CardId = 1008, Balance = 100.00 });
            listCards.AddCard(new CardInfo() { CardId = 1009, Balance = 100.00});
            listCards.AddCard(new CardInfo() { CardId = 1010, Balance = 100.00});

            Console.WriteLine("Please enter Entry Station :");
            string EntryStation = Console.ReadLine();
            Console.WriteLine("Please enter Exit Station :");
            string ExistStation = Console.ReadLine();
            Console.WriteLine("Card ID :");
            int cardID = Convert.ToInt32(Console.ReadLine());
            // DateTime travelDate = DateTime.Now;
            CardInfo swipedCardInfo = listCards.GetCardInfoByCardId(cardID);

            if (swipedCardInfo.Balance < 50)
            {
                Console.WriteLine("Does not have enough funds. Plz enter added Fare");

            }

            StationList Stat = new StationList();
            Station station = Stat.GetStationByStationName(EntryStation);
            int NoofStations = Stat.CalculateNoofStations(EntryStation, ExistStation);
            double fare = listCards.CalculateFare(NoofStations, DateTime.Now);
            if (swipedCardInfo.Balance < fare)
                Console.WriteLine("Does not have enough funds. Contact front desk");
            else
                swipedCardInfo.Balance = swipedCardInfo.Balance - fare;
        }

       
    }
}
