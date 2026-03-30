namespace PetMauiApp.Pages;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

  
private async void OnConnectClicked(object sender, EventArgs e)
    {
        try
        {
           
            string url = "https://www.linkedin.com/in/payal-aggarwal-188bb72a5".Trim();

            Uri uri = new Uri(url);
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {
           
            await DisplayAlert("Error", $"Could not open browser: {ex.Message}", "OK");
        }
    }
}