namespace PetMauiApp.Pages;

public partial class PaymentPage : ContentPage
{
	public PaymentPage()
	{
		InitializeComponent();
	}
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CartPage());
    }
    private async void OnPayNowClicked(object sender, EventArgs e)
    {
        bool isConfirm = await DisplayAlert("Confirm Payment", "Do you want to proceed with this payment?", "Yes", "No");

        if (isConfirm)
        {
            await DisplayAlert("Success", "Payment Successful!", "OK");
            await Navigation.PopToRootAsync();
        }
    }
}