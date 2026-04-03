using PetMauiApp.Models;
using System.Collections.ObjectModel;
namespace PetMauiApp.Pages;

public partial class CartPage : ContentPage
{
    public ObservableCollection<CartItem> MyCart { get; set; } = new();
    double shippingCharges = 520.00;
    public CartPage()
	{

		InitializeComponent();
        MyCart.Add(new CartItem { Name = "Royal Canin Rottweiler", Weight = "3kg", UnitPrice = 7850, Quantity = 3, Image = "food_royal.png" });
        MyCart.Add(new CartItem { Name = "Automatic Pet Feeder", Weight = "250g", UnitPrice = 24489, Quantity = 2, Image = "pet_feeder.png" });
        MyCart.Add(new CartItem { Name = "Josera Mini Deluxe", Weight = "900g", UnitPrice = 2900, Quantity = 5, Image = "mini.png" });

        CartListView.ItemsSource = MyCart;
        CalculateBill();
    }
    private void CalculateBill()
    {
        double subtotal = 0;
        foreach (var item in MyCart)
        {
            subtotal += (item.UnitPrice * item.Quantity);
        }

        SubtotalLabel.Text = $"Rs {subtotal:N2}";
        TotalLabel.Text = $"Rs {(subtotal + shippingCharges):N2}";
    }

    private void OnDeleteSwipe(object sender, EventArgs e)
    {
        var item = (sender as SwipeItem).BindingContext as CartItem;
        if (item != null)
        {
            MyCart.Remove(item);
            CalculateBill();
        }
    }

    private void OnIncrease(object sender, EventArgs e)
    {
        var item = (sender as Button).BindingContext as CartItem;
        if (item != null)
        {
            item.Quantity++;
            RefreshUI(); 
        }
    }

    private void OnDecrease(object sender, EventArgs e)
    {
        var item = (sender as Button).BindingContext as CartItem;
        if (item != null && item.Quantity > 1)
        {
            item.Quantity--;
            RefreshUI();
        }
    }

    private void RefreshUI()
    {
      
        CartListView.ItemsSource = null;
        CartListView.ItemsSource = MyCart;
        CalculateBill();
    }
    private async void Btn_Checked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaymentPage());
    }
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Dashboard());
    }
}