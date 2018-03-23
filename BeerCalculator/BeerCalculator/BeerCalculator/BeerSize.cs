using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerCalculator
{
    class BeerSize
    {
        public string BeerLink { get; set; }
        public string Size { get; set; }

        public BeerSize(string link, string size)
        {
            BeerLink = link;
            Size = size;
        }

    }
}
