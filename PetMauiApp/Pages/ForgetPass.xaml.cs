namespace PetMauiApp.Pages;

public partial class ForgetPass : ContentPage
{
	public ForgetPass()
	{
		InitializeComponent();
	}
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Regiester());
    }
}