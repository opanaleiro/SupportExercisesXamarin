using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio_7
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Buton1_Clicked(object sender, EventArgs e)
        {
            await buton1.TranslateTo(0,-100,1000, Easing.Linear);
            await buton1.RotateTo(180, 1000, Easing.SinInOut);
        }
    }
}
