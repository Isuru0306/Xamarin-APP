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
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        private void attendance_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Attendance());
        }

        private void dailytask_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new TaskSchedule());
        }

        private void user_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new CustomersPage());
        }

        private void pricelist_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PriceList());
        }

        private void salesOrder_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PriceList());
        }

        private void collections_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Collection());

        }

        private void info_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Not complete", "OK");
        }
    }
}