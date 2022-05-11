using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Handy
{
    //enums
    public enum DeliveryType
    {
        Rush3Days,
        Rush5Days,
        Rush7Days,
        NoRush
    }
    public class DeskQuote
    {
        // properties
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public string Shipping { get; set; }
        public Desk Desk { get; set; }
        public DeliveryType DeliveryType { get; set; }
        public decimal QuoteAmount { get; set; }

        // methods
        public decimal GetQuote()
        {
            // still need to code out this portion:
            return 0;
        }
    }
}
