using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroApp
{
    enum Action
    {
        Entry = 0,
        Exit = 1
    }

    enum TransactionStatus
    {
        Close = 0,
        Open = 1
    }
    class Activity
    {
        public Action ActiveAction { get; set; }
        public int SwipeStationId { get; set; }
        public int CardID { get; set; }
        DateTime SwipeDateTime;
    }

    class ActivityList
    {
        public int TransactionID { get; set; }
        public TransactionStatus CurrentTransactionStatus {get;set;}
        public int EntryStationID { get; set; }
        public int ExitStationID { get; set; }

    }
}
