namespace PetMauiApp.Pages;

public partial class VetDr : ContentPage
{
	public VetDr()
	{
		InitializeComponent();
	}
	private  async void Book(object sender, EventArgs e)
	{
		 await Navigation.PushAsync(new BookAppointment());
	}
}