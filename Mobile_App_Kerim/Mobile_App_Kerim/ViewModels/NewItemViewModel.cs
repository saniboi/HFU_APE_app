using Mobile_App_Kerim.Models;
using System;
using System.Net.Mime;
using Mobile_App_Kerim.Services;
using Mobile_App_Kerim.Views;
using Xamarin.Forms;

namespace Mobile_App_Kerim.ViewModels
{
    public class NewItemViewModel : BaseViewModel
    {
        private string name;
        private string vorname;
        private string strasse;
        private int strassennummer;
        private string ort;
        private int postleitzahl;
        private int telefonnummer;
        private DateTime geburtsdatum;

        public NewItemViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !string.IsNullOrWhiteSpace(name)
                && !string.IsNullOrWhiteSpace(vorname)
                && !string.IsNullOrWhiteSpace(strasse)
                && !string.IsNullOrWhiteSpace(ort);
        }

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        public string Vorname
        {
            get => vorname;
            set => SetProperty(ref vorname, value);
        }

        public string Strasse
        {
            get => strasse;
            set => SetProperty(ref strasse, value);
        }

        public int Strassennummer
        {
            get => strassennummer;
            set => SetProperty(ref strassennummer, value);
        }

        public string Ort
        {
            get => ort;
            set => SetProperty(ref ort, value);
        }

        public int Postleitzahl
        {
            get => postleitzahl;
            set => SetProperty(ref postleitzahl, value);
        }

        public int Telefonnummer
        {
            get => telefonnummer;
            set => SetProperty(ref telefonnummer, value);
        }

        public DateTime Geburtsdatum
        {
            get => geburtsdatum;
            set => SetProperty(ref geburtsdatum, value);
        }

        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        private static async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave()
        {
            var item = new Item
            {
                Id = Guid.NewGuid().ToString(),
                Name = Name,
                Vorname = Vorname,
                Strasse = Strasse,
                Strassennummer = Strassennummer,
                Ort = Ort,
                Postleitzahl = Postleitzahl,
                Telefonnummer = Telefonnummer,
                Geburtsdatum = Geburtsdatum
            };

            MessagingCenter.Send(this, "AddItem", item);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void LoadNotes(string itemId)
        {
            try
            {
                int id = Convert.ToInt32(itemId);
                // Retrieve the note and set it as the BindingContext of the page.
                Item item = await App.Database.GetItemAsync(itemId);
                
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to load note.");
            }
        }
    }
}
