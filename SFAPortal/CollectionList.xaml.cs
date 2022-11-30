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
    public partial class Collection : ContentPage
    {
        public Collection()
        {
            InitializeComponent();
            this.BindingContext = new CollectionListViewModel();
        }

        private void mainMenu_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}