using System.Linq;
using Mobile_App_Kerim.Models;
using Mobile_App_Kerim.ViewModels;
using Xamarin.Forms;

namespace Mobile_App_Kerim.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Retrieve all the notes from the database, and set them as the
            // data source for the CollectionView.
            //ItemsListView.ItemsSource = await App.Database.GetItemsAsync();
        }

        async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                // Navigate to the NoteEntryPage, passing the ID as a query parameter.
                Item item = (Item)e.CurrentSelection.FirstOrDefault();
                await Shell.Current.GoToAsync($"{nameof(NewItemPage)}?{nameof(NewItemPage.Id)}={item.Id.ToString()}");
            }
        }
    }
}