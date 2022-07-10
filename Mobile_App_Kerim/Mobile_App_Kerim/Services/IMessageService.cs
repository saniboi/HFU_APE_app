using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_App_Kerim.Services
{
    public interface IMessageService
    {
        Task ShowAsync(string title, string message, string cancel);
    }
}
