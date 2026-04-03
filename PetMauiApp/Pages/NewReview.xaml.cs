namespace PetMauiApp.Pages;

public partial class NewReview : ContentPage
{
	public NewReview()
	{
		InitializeComponent();
	}

    private async void OnPostReviewClicked(object sender, EventArgs e)
    {
        // Add your logic to save the review here
        await DisplayAlert("Success", "Your review has been posted!", "OK");
        await Navigation.PushAsync(new Dashboard());
    }
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddReview());
    }
}