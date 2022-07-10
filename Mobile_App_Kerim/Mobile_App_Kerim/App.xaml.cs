using Mobile_App_Kerim.Services;
using Mobile_App_Kerim.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile_App_Kerim
{
    public partial class App : Application
    {

        public App()
        {
            DependencyService.Register<IMessageService, MessageService>();
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
