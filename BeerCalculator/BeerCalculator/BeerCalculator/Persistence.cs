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

        public List<BeerType> GetBeerList()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM beercalculator.bieren;", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable(strDataTableName);
            da.Fill(dt);
            return dt;
        }
    }
}
