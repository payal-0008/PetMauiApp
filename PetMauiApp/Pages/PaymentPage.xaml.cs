namespace PetMauiApp.Pages;

public partial class PaymentPage : ContentPage
{
	public PaymentPage()
	{
		InitializeComponent();
	}
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void OnPayNowClicked(object sender, EventArgs e)
    {
        // Simple validation check
        bool isConfirm = await DisplayAlert("Confirm Payment", "Do you want to proceed with this payment?", "Yes", "No");

        if (isConfirm)
        {
            // Yahan par aap Success page par navigate kar sakte ho
            await DisplayAlert("Success", "Payment Successful!", "OK");
        }
    }
}