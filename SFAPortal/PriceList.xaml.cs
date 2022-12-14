using SFAPortal.Model;
using SFAPortal.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SFAPortal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PriceList : ContentPage
    {

        List<PriceLists> PriceLists = new List<PriceLists>();
        public PriceList()
        {
            InitializeComponent();
            this.BindingContext = new PriceListViewModel();
        }

        private void mainMenu_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}