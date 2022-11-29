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
    public partial class Attendance : ContentPage
    {

        List<String> shiftTypes = new List<String>();
        public Attendance()
        {
            InitializeComponent();

            shiftTypes.Add("Full day");
            shiftTypes.Add("Half day");
            shiftTypes.Add("Short leave");

            shiftType.ItemsSource = shiftTypes;

        }

        private void mainMenu_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}