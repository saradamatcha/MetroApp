using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroApp
{
    class CardInfo
    {
        public int CardId { get; set; }
        public double Balance { get; set; }
        public CardInfo()
        {

        }
        public CardInfo (int cardId, double balance )
        {
            CardId = cardId;
            Balance = balance;
        }
    }

    class CardList
    {
        List<CardInfo> Cards = new List<CardInfo>();
        public void AddCard(CardInfo ci)
        {

            if(ci!=null)
            {
                Cards.Add(ci);
            }
            
        }

        public void RemoveCard(CardInfo ci)
        {
            if (ci!=null)
            {
                Cards.Remove(ci);
            }
        }

        public double AddBlance (double prevBal , double addedFunds)
        {
            return prevBal + addedFunds ;
        }
        public CardInfo GetCardInfoByCardId(int cardId)
        {
            return Cards.FirstOrDefault(c => c.CardId == cardId);
           
        }

        public double CalculateFare(int stations, DateTime travelDate)
        {
            DayOfWeek day = travelDate.DayOfWeek;

            if ((day == DayOfWeek.Saturday) || (day == DayOfWeek.Sunday))
                return 5.5 * stations;
            else
                return 7 * stations;
        }
    }
}
