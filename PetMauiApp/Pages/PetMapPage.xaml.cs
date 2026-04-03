namespace PetMauiApp.Pages;

public partial class PetMapPage : ContentPage
{
	public PetMapPage()
	{
		InitializeComponent();
	}
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Dashboard());
    }
}