using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerCalculator
{
    class BeerSize
    {
        int _BeerQuantity;
        string _BeerLink;
        public string BeerLink { get; set; }

        public int BeerQuantity
        {
            get { return _BeerQuantity; }
            set { _BeerQuantity = value; }
        }



    }
}
