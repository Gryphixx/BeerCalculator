using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerCalculator
{
    class Bussines
    {
        Persistence per = new Persistence();

        public List<BeerType> GetBeers()
        {
            return per.GetCaraPrice();
        }
    }
}
