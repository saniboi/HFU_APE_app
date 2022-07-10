using Mobile_App_Kerim.ViewModels;
using Xamarin.Forms.Xaml;

namespace Mobile_App_Kerim.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
    }
}