namespace PetMauiApp.Pages;

public partial class Get_Started : ContentPage
{
	public Get_Started()
	{
		InitializeComponent();
	}
    private async void login(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Regiester());
    }
    private async void get_started(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Regiester());
    }
}