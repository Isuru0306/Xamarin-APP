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
    public partial class TaskSchedule : ContentPage
    {
        List<Tasks> Tasks = new List<Tasks>();
        List<string> typeList = new List<string>();
        public TaskSchedule()
        {
            InitializeComponent();

            typeList.Add("Type 1");
            typeList.Add("Type 2");
            typeList.Add("Type 3");

            type.ItemsSource = typeList;

            this.BindingContext = new TaskListViewModel();


        }

        private void mainMenu_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}