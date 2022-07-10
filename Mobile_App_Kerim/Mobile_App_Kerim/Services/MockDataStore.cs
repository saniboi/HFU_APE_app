using Mobile_App_Kerim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mobile_App_Kerim.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        //readonly List<Item> items;

        public MockDataStore()
        {
            //items = new List<Item>()
            //{
            //    new Item { Id = Guid.NewGuid().ToString(), Name = "San", Vorname = "Kerim", Geburtsdatum = new DateTime(1988, 11, 20), Strasse = "Kantonsschulstrasse", 
            //        Strassennummer = 6, Ort = "Bülach", Postleitzahl = 8180, Telefonnummer = 0797965000},
            //    new Item { Id = Guid.NewGuid().ToString(), Name = "San", Vorname = "Kerem", Geburtsdatum = new DateTime(2019, 12, 27), Strasse = "Kantonsschulstrasse",
            //        Strassennummer = 6, Ort = "Bülach", Postleitzahl = 8180, Telefonnummer = 0797965000},
            //    new Item { Id = Guid.NewGuid().ToString(), Name = "San", Vorname = "Zeynep", Geburtsdatum = new DateTime(1984, 08, 31), Strasse = "Kantonsschulstrasse",
            //        Strassennummer = 6, Ort = "Bülach", Postleitzahl = 8180, Telefonnummer = 0797965000},
            //    new Item { Id = Guid.NewGuid().ToString(), Name = "San", Vorname = "Zehra", Geburtsdatum = new DateTime(2015, 12, 12), Strasse = "Kantonsschulstrasse",
            //        Strassennummer = 6, Ort = "Bülach", Postleitzahl = 8180, Telefonnummer = 0797965000}
            //};
        }

        //public async Task<bool> AddItemAsync(Item item)
        //{
        //    items.Add(item);

        //    return await Task.FromResult(true);
        //}


        //public async Task<bool> UpdateItemAsync(Item item)
        //{
        //    var oldItem = items.FirstOrDefault(arg => arg.Id == item.Id);
        //    items.Remove(oldItem);
        //    items.Add(item);

        //    return await Task.FromResult(true);
        //}

        //public async Task<bool> DeleteItemAsync(string id)
        //{
        //    var oldItem = items.FirstOrDefault(arg => arg.Id == id);
        //    items.Remove(oldItem);

        //    return await Task.FromResult(true);
        //}

        //public async Task<Item> GetItemAsync(string id)
        //{
        //    return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        //}

        //public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        //{
        //    return await Task.FromResult(items);
        //}
    }
}