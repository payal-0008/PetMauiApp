using Plugin.Firebase.CloudMessaging;
using Microsoft.Maui.Controls;
namespace PetMauiApp.Pages;

public partial class Regiester : ContentPage
{
	public Regiester()
	{
		InitializeComponent();
    }
    private void OnRegisterTapped(object sender, EventArgs e)
    {
        LoginLayout.IsVisible = false;
        RegisterLayout.IsVisible = true;
        RegisterLabel.TextColor = (Color)Application.Current.Resources["BtnColor"];
        LoginLabel.TextColor = (Color)Application.Current.Resources["TitleColor"];
    }
    private void OnLoginTapped(object sender, EventArgs e)
    {
        LoginLayout.IsVisible = true;
        RegisterLayout.IsVisible = false;
        LoginLabel.TextColor = (Color)Application.Current.Resources["BtnColor"];
        RegisterLabel.TextColor = (Color)Application.Current.Resources["TitleColor"];
    }
    private async void LoginTapped(object sender,EventArgs e)
    {
        {
#if ANDROID || IOS
            try
            {
                try
                {
                    if (Firebase.FirebaseApp.Instance == null)
                    {
                        Firebase.FirebaseApp.InitializeApp(Android.App.Application.Context);
                    }
                }
                catch (Exception initEx)
                {
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

        var savedEmail = Preferences.Get("RegEmail", "");
        var savedPassword = Preferences.Get("RegPassword", "");

        if (email == savedEmail && password == savedPassword)
        {
            Preferences.Set("IsLoggedIn", true);

            await DisplayAlert("✅ Login Successful", "Welcome back!", "Continue");

            Application.Current.Windows[0].Page = new AppShell();
        }
        else
        {
            await DisplayAlert("❌ Login Failed", "Invalid Email or Password", "OK");
        }
    }
    private async void Btn(object sender, EventArgs e)
    {
        string name = RegNameEntry.Text;
        string email = RegEmailEntry.Text;
        string password = RegPasswordEntry.Text;

        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
        {
            await DisplayAlert("Error", "Please fill all fields", "OK");
            return;
        }
        Preferences.Set("Name", name);
        Preferences.Set("RegEmail", email);
        Preferences.Set("RegPassword", password);

        await DisplayAlert("Success", "Registered Successfully", "OK");
        OnLoginTapped(null, null);
    }
}