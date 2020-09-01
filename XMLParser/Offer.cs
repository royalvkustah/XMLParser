using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLParser
{
    class Offer
    {
        public int id;
        public string type;
        public int bid;
       
        public bool available;

        public Offer(int id, string type, int bid,  bool available)
        {
            this.id = id;
            this.type = type;
            this.bid = bid;
            
            this.available = available;
        }
    }
}
