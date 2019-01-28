using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Ejercicio_2
{
    public partial class MainPage : MasterDetailPage
    {
        public List<Pagina> menuList { get; set; }
        public MainPage()
        {
            InitializeComponent();
     
     

            menuList = new List<Pagina>();

            // Adding menu items to menuList and you can define title ,page and icon
            menuList.Add(new Pagina() { Title = "Home", Icon = "home.png", TargetType = typeof(HomePage) });
            menuList.Add(new Pagina() { Title = "Setting", Icon = "setting.png", TargetType = typeof(SettingPage) });
            menuList.Add(new Pagina() { Title = "Help", Icon = "help.png", TargetType = typeof(HelpPage) });
            menuList.Add(new Pagina() { Title = "LogOut", Icon = "logout.png", TargetType = typeof(LogoutPage) });

            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = menuList;

            // Initial navigation, this can be used for our home page
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
        }

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (Pagina)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}
