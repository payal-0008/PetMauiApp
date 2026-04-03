using PetMauiApp.Models;
namespace PetMauiApp.Pages;

public partial class PetDetailPage : ContentPage
{
	public PetDetailPage(Pet selectedPet)
	{
		InitializeComponent();
        BindingContext = selectedPet;
    }
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Dashboard());
    }
}