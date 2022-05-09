using Mobile_App_Kerim.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Mobile_App_Kerim.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}