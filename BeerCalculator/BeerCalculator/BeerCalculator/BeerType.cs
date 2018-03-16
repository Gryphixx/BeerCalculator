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

        public void FillPickerWithSizes(Picker pckr)
        {
            foreach (BeerSize size in Sizes)
            {

            }
        }
        
        public BeerType(string beerName)
        {
            this.BeerName = BeerName;
        }
    }
}
