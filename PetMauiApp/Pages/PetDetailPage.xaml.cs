using PetMauiApp.Models;
namespace PetMauiApp.Pages;

public partial class PetDetailPage : ContentPage
{
	public PetDetailPage(Pet selectedPet)
	{
		InitializeComponent();
        BindingContext = selectedPet;
    }
}