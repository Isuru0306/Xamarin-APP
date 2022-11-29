using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SFAPortal
{
    
    public partial class MainPage : ContentPage
    {
        List<String> companyLists = new List<String>();
        public MainPage()
        {
            InitializeComponent();


            companyLists.Add("Company 1");
            companyLists.Add("Company 2");
            companyLists.Add("Company 3");
            companyLists.Add("Company 4");
            companyLists.Add("Company 5");

            companyList.ItemsSource = companyLists;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Home());
        }
    }
}
