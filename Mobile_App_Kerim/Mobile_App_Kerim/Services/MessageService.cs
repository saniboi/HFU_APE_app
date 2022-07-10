using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_App_Kerim.Services
{
    public class MessageService : IMessageService
    {
        public async Task ShowAsync(string title, string message, string cancel)
        {
            await App.Current.MainPage.DisplayAlert(title, message, cancel);
        }
    }
}
