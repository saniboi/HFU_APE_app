using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace Mobile_App_Kerim.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        private string itemId;
        private string name;
        private string vorname;
        private string strasse;
        private int strassennummer;
        private string ort;
        private int postleitzahl;
        private int telefonnummer;
        private DateTime geburtsdatum;

        public string Id { get; set; }

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

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Name = item.Name;
                Vorname = item.Vorname;
                Strasse = item.Strasse;
                Strassennummer = item.Strassennummer;
                Ort = item.Ort;
                Postleitzahl = item.Postleitzahl;
                Telefonnummer = item.Telefonnummer;
                Geburtsdatum = item.Geburtsdatum;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
