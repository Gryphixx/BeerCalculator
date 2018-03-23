using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerCalculator
{
    class BeerSize
    {
        string _BeerLink;
        public string BeerLink { get; set; }
        public string BeerQuantity { get; set; }

        public BeerSize(string link, string quantity)
        {
            BeerLink = link;
            BeerQuantity = quantity;
        }

    }
}
