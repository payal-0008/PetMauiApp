namespace PetMauiApp.Pages;

public partial class MyAddressPage : ContentPage
{
	public MyAddressPage()
	{
		InitializeComponent();
	}
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void OnSaveAddressClicked(object sender, EventArgs e)
    {
      
        await DisplayAlert("Saved", "Address has been saved successfully!", "OK");
        await Navigation.PopAsync();
    }
}