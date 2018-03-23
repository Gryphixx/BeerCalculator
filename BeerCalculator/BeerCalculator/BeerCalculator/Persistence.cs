using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using MySql.Data.MySqlClient;
using Syste

namespace BeerCalculator
{
    class Persistence
    {
        static string conString = "server=maerievoet.ddns.net;user id=GIP;port=3306;database=beercalculator; password=Usman123";
        MySqlConnection con = new MySqlConnection(conString);
        BeerType cara = new BeerType("Cara");
        

        public List<BeerType> GetBeerList()
        {
            List<BeerType> beer = new List<BeerType>();
            beer.Add(cara);
            return beer;
        }

        public Persistence()
        {
            BeerSize blik33 = new BeerSize("https://colruyt.collectandgo.be/cogo/nl/artikeldetail/5383/everyday-cara-pils-4-4-vol-blik-33cl", "Blik 33cl");
            cara.Sizes.Add(blik33);
        }
    }
}
