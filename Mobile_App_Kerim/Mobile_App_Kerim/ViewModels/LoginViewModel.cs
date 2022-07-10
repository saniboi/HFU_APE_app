using Mobile_App_Kerim.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Mobile_App_Kerim.Services;
using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Mobile_App_Kerim.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly IMessageService messageService;
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            messageService = DependencyService.Get<IMessageService>();
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            var availability = await
                CrossFingerprint.Current.IsAvailableAsync();

            if (!availability)
            {

                await messageService.ShowAsync("Warning!", "No biometrics available",
                    "OK");
                return;
            }

            var authResult = await
                CrossFingerprint.Current.AuthenticateAsync(new AuthenticationRequestConfiguration("Heads up!", "I would like to use your biometrics, please!"));

            if (authResult.Authenticated)
            {
                await messageService.ShowAsync("Yaay!", "Here is the secrets", "Thanks!");
                await Shell.Current.GoToAsync($"//{nameof(InfoPage)}");
            }
            
        }
    }
}
