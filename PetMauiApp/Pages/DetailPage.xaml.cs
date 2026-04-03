
using static PetMauiApp.Models.ShopModel;
namespace PetMauiApp.Pages;

public partial class DetailPage : ContentPage
{
	public DetailPage(ProductModel selectedProduct)
	{
		InitializeComponent();
        BindingContext = selectedProduct;
    }
	 private async void Btn_add(object sender,EventArgs e)
	{
		await Navigation.PushAsync(new CartPage());
	}
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}