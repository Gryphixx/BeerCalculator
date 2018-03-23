using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BeerCalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            FillPicker();
        }
        Bussines bus = new Bussines();

        private void FillPicker()
        {
            List<BeerType> beer = new List<BeerType>();
            beer = bus.GetBeers();
            foreach (BeerType item in beer)
            {
                
            }          
        }
    }
}
