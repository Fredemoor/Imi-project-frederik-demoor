using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KennelListPage : ContentPage
    {
        //MockLocationService mockLocationService;
        public KennelListPage()
        {
            InitializeComponent();
            //mockLocationService = new MockLocationService();
        }
        //public async Task GetLocations()
        //{
        //    var locations = await mockLocationService.GetAllAsync();
        //    kennelList.ItemsSource = locations;
        //}

        //protected async override void OnAppearing()
        //{
        //    await GetLocations();
        //    base.OnAppearing();
        //}

        //private async void MenuItem_Edit_Clicked(object sender, EventArgs e)
        //{
        //    var selected = ((MenuItem)sender).CommandParameter as Location;
        //    await DisplayAlert("Edit", $"Editing {selected.Name}", "OK");
        //    await Navigation.PushAsync(new KennelListPage());
        //}

        //private async void MenuItem_Delete_Clicked(object sender, EventArgs e)
        //{
        //    var selected = ((MenuItem)sender).CommandParameter as Location;
        //    await mockLocationService.DeleteAsync(selected);
        //    kennelList.ItemsSource = null;
        //    await GetLocations();
        //}
    }
}