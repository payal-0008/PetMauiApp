namespace PetMauiApp.Pages;

public partial class BookAppointment : ContentPage
{
	public BookAppointment()
	{
		InitializeComponent();
	}
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Dashboard());
    }
}