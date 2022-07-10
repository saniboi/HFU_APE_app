using Mobile_App_Kerim.Services;
using Mobile_App_Kerim.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile_App_Kerim
{
    public partial class App : Application
    {
        static ItemDatabase database;

        // Create the database connection as a singleton.
        public static ItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ItemDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Items.db"));
                }
                return database;
            }
        }

        public App()
        {
            
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
            DependencyService.Register<IMessageService, MessageService>();
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
