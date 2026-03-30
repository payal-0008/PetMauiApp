namespace PetMauiApp.Pages;

public partial class AddReview : ContentPage
{
	public AddReview()
	{
		InitializeComponent();
	}
	private void OnImageButtonClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new NewReview());
	}
}