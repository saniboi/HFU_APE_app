using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Mobile_App_Kerim.Models;
using SQLite;

namespace Mobile_App_Kerim.Services
{
    public class ItemDatabase
    {
        readonly SQLiteAsyncConnection database;

        public ItemDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Item>().Wait();
        }

        public Task<List<Item>> GetItemsAsync()
        {
            //Get all Items.
            return database.Table<Item>().ToListAsync();
          
        }

        public Task<Item> GetItemAsync(string id)
        {
            // Get a specific Item.
            return database.Table<Item>()
                .Where(i => i.Id == id)
                .FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Item Item)
        {
            //-------------------------------------Später anschauen könnte Fehler erzeugen !!!!!!!!!!!!!!!!!!!!!!!
            if (Item.Id != "0")
            {
                // Update an existing Item.
                return database.UpdateAsync(Item);
            }

            // Save a new Item.
            return database.InsertAsync(Item);
        }

        public Task<int> DeleteItemAsync(Item Item)
        {
            // Delete a Item.
            return database.DeleteAsync(Item);
        }
    }
}
