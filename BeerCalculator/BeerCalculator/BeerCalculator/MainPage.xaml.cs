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

        private void FillPicker()
        {
            var picker = new Picker { Title = "Select a beer" };
            picker.Items.Add("hehe");
        }
    }
}
