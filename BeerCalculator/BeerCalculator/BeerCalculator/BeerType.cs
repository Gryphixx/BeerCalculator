using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BeerCalculator
{
    class BeerType
    {
        public string BeerName { get; }
        public List<BeerSize> Sizes = new List<BeerSize>();

        public override string ToString()
        {
            return BeerName;
        }

        public BeerType(string beerName)
        {
            this.BeerName = BeerName;
        }
    }
}
