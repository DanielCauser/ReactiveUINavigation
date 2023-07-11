using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ReactiveUI;
using ReactiveUI.XamForms;

namespace ReactiveUINavigation
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();
            MainPage = new AppBootstrapper().Init();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

