using PetMauiApp.Models;
using System.Collections.ObjectModel;
using static PetMauiApp.Models.ShopModel;

namespace PetMauiApp.Pages;

public partial class Dashboard : ContentPage
{
    public ObservableCollection<Pet> Pets { get; set; }
    public Dashboard()
	{
		InitializeComponent();
       
        Pets = new ObservableCollection<Pet>
        {
            new Pet { Name = "Bella", Image = "dog1.png",  BackColor="#F0BB22",Breed="Border Collie", Gender="Female", Age="2 Years", Weight="18kg", Color="Black & White"},
            new Pet { Name = "Roudy", Image = "dog2.png", BackColor="#7A86AE",Breed="Rottweiler", Gender="Male", Age="3 Years", Weight="45kg", Color="Black & Tan"},
            new Pet { Name = "Furry", Image = "dog3.png",BackColor="#E28E69",Breed="Samoyed", Gender="Male", Age="1 Year", Weight="22kg", Color="White" }
        };

        BindingContext = this;
    }
    private async void OnPetTapped(object sender, TappedEventArgs e)
    {
        if (e.Parameter is Pet selectedPet)
        {
            await Navigation.PushAsync(new PetDetailPage(selectedPet));
        }
    }
    private void Appointment(object sender,EventArgs e)
    {
        Navigation.PushAsync(new BookAppointment());
    }
    private void AddReview(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddReview());
    }
    private void vetdr(object sender, EventArgs e)
    {
        Navigation.PushAsync(new VetDr());
    }
    private void next(object sender, EventArgs e)
    {
        Navigation.PushAsync(new VetPage());
    }
    private async void OnPetLocationTapped(object sender, EventArgs e)
    {
        
        await Navigation.PushAsync(new PetMapPage());
    }
    private async void frame_next(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new PetFood());
    }
    private async void btn_cart(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CartPage());
    }
    private async void OnProductDetailTapped(object sender, TappedEventArgs e)
    {
        string productType = e.Parameter as string;
        ProductModel data = null;

        if (productType == "Josera")
        {
            data = new ProductModel
            {
                Name = "Josi Dog Master Mix",
                Brand = "Josera",
                Weight = "900g",
                Image = "image.png",
                Price = "Rs 2900.00"
            };
        }
        else if (productType == "HappyPet")
        {
            data = new ProductModel
            {
                Name = "Happy Dog - Profi Line",
                Brand = "Happy Pet",
                Weight = "500g",
                Image = "image2.png",
                Price = "Rs 1500.00"
            };
        }

        if (data != null)
        {
            await Navigation.PushAsync(new ProductDetailPage(data));
        }
    }
}