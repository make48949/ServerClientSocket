using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class ClientModels
    {
        public string ProductId { get; set; }
        public decimal MinPrice { get; set; }
        public decimal SellPrice { get; set; }
        public double AuctionLength { get; set; }

        public double StartTime { get; set; }
        public double EndTime { get; set; }

    }
}
