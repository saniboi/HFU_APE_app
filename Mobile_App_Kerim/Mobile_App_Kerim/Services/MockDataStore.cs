using Mobile_App_Kerim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mobile_App_Kerim.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description.", Age = 16 },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description.", Age = 18 },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description.", Age = 20 },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description.", Age = 22 },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description.", Age = 24 },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description.", Age = 26 }
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }


        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}