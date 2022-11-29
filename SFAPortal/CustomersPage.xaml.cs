using SFAPortal.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SFAPortal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomersPage : ContentPage
    {
       
        List<Customers> Customers = new List<Customers>();
        public CustomersPage()
        {
            InitializeComponent();
            this.BindingContext = new CustomerListViewModel();
        }

        private void mainMenu_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }


    }
}