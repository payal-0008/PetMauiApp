namespace PetMauiApp.Pages;

public partial class Profile : ContentPage
{
	public Profile()
	{
		InitializeComponent();
	}
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Dashboard());
    }

    private async void OnLogout(object sender, EventArgs e)
    {
        await DisplayAlert("Logout", "Signed out successfully", "OK");

        await Navigation.PushAsync(new Regiester());
    }
    private async void add_next(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddDevice());
    }
    private async void add_pet(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddPet());
    }
    private async void btn_cart(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CartPage());
    }
    private async void btn_about(object sender,EventArgs e)
    {
        await Navigation.PushAsync(new AboutPage());
    }
    private async void btn_address(object sender,EventArgs e)
    {
        await Navigation.PushAsync(new MyAddressPage());
    }
}