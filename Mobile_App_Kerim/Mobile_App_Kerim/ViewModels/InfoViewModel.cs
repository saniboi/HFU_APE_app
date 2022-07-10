using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Mobile_App_Kerim.ViewModels
{
    public class InfoViewModel : BaseViewModel
    {
        public InfoViewModel()
        {
            Title = "Kontakte";
            //OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        //public ICommand OpenWebCommand { get; }
    }
}