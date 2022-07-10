using Mobile_App_Kerim.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile_App_Kerim.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }
    }
}