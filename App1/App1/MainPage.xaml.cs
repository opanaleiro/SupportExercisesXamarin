
using App1;
using System;
using Xamarin.Forms;

namespace MasterDetailsPage
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new HomePage());
            IsPresented = false;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AddEmployee());
            IsPresented = false;
        }
        private void Button_Clicked2(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ListEmployee());
            IsPresented = false;
        }

        private void Button_Clicked3(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AboutUs());
            IsPresented = false;
        }
        private void Button_Clickded4(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ContactUs());
            IsPresented = false;
        }
    }
}