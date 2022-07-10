using System;
using Mobile_App_Kerim.ViewModels;
using SQLite;

namespace Mobile_App_Kerim.Models
{
    public class Item : BaseViewModel
    {
        [PrimaryKey]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Strasse { get; set; }
        public int Strassennummer { get; set; }
        public string Ort { get; set; }
        public int Postleitzahl { get; set; }
        public int Telefonnummer { get; set; }
        public DateTime Geburtsdatum { get; set; }
    }
}