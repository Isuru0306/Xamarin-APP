using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SFAPortal
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TaskSchedule();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
