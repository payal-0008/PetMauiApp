using Plugin.Firebase.CloudMessaging;
using Microsoft.Maui.Controls;
namespace PetMauiApp.Pages;



public partial class Regiester : ContentPage
{
	public Regiester()
	{
		InitializeComponent();
    }
	
    private void OnLoginTapped(object sender, EventArgs e)
    {
        LoginLayout.IsVisible = true;
        RegisterLayout.IsVisible = false;
        LoginLabel.TextColor = (Color)Application.Current.Resources["BtnColor"];
        RegisterLabel.TextColor = (Color)Application.Current.Resources["TitleColor"];
    }

    private void OnRegisterTapped(object sender, EventArgs e)
    {
        LoginLayout.IsVisible = false;
        RegisterLayout.IsVisible = true;
        RegisterLabel.TextColor = (Color)Application.Current.Resources["BtnColor"];
        LoginLabel.TextColor = (Color)Application.Current.Resources["TitleColor"];
    }
    private async void LoginTapped(object sender,EventArgs e)
    {
        {
#if ANDROID || IOS
            try
            {
                // Ensure Firebase is initialized for this process. Use Application.Context on Android.
                try
                {
                    if (Firebase.FirebaseApp.Instance == null)
                    {
                        Firebase.FirebaseApp.InitializeApp(Android.App.Application.Context);
                    }
                }
                catch (Exception initEx)
                {
                    // log init exception but continue to attempt using plugin which will give clearer error in logs
                    System.Diagnostics.Debug.WriteLine($"Firebase init warning: {initEx}");
                }

                await CrossFirebaseCloudMessaging.Current.CheckIfValidAsync();

                var token = await CrossFirebaseCloudMessaging.Current.GetTokenAsync();

                await Share.RequestAsync(new ShareTextRequest
                {
                    Text = token,
                    Title = "Share Token"
                });

                System.Diagnostics.Debug.WriteLine($"Firebase Token: {token}");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"An error occurred: {ex.Message}", "OK");
            }
#endif
        }
        string email = EmailEntry.Text;
        string password = PasswordEntry.Text;
        if (email == "abc@gmail.com" && password == "123")
        {
            await DisplayAlert("✅ Login Successful", "Welcome back! Redirecting to Dashboard...", "Continue");
            await Navigation.PushAsync(new Dashboard());
        }
        else
        {
            await DisplayAlert("❌ Login Failed", "Invalid Email or Password", "OK");
        }
    }
    private async void Btn(object sender,EventArgs e)
    {
        await Navigation.PushAsync(new Dashboard());
    }
}