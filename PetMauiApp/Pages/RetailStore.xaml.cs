namespace PetMauiApp.Pages;

public partial class RetailStore : ContentPage
{
	public RetailStore()
	{
		InitializeComponent();
	}
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}