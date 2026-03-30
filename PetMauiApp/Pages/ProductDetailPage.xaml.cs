using static PetMauiApp.Models.ShopModel;

namespace PetMauiApp.Pages;

public partial class ProductDetailPage : ContentPage
{
	public ProductDetailPage(ProductModel product)
	{
		InitializeComponent();
        BindingContext = product;
    }
	private async void Btn_plus(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new CartPage());
	}
}