using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void rotarBoton()
        {

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
           await boton1.RotateTo(360, 800, Easing.SinInOut);
        }
    }
}
