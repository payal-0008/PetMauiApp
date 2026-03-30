using PetMauiApp.Models;
using System.Collections.ObjectModel;
using static PetMauiApp.Models.ShopModel;

namespace PetMauiApp.Pages;

public partial class PetFood : ContentPage
{
    public ObservableCollection<ProductModel> RecommendedProducts { get; set; } = new();
    public ObservableCollection<ProductModel> TopSellingProducts { get; set; } = new();

    private List<ProductModel> AllRecommended = new();
    private List<ProductModel> AllTopSelling = new();
    public List<ProductModel> AllProducts { get; set; } = new();
    public PetFood()
    {
        InitializeComponent();
        LoadData();
        BindingContext = this;
        FilterData("Food");
    }

    void LoadData()
    {
        //  Recommended
        AllRecommended = new List<ProductModel>
        {
            //Food Items
            new ProductModel { Name = "Josera Mini Deluxe", Category="Food", Brand = "Josera", Weight = "900g", Price = "Rs 2900.00", Image = "mini.png", Tag = "Furry", TagColor = "#F9ECE4" },
            new ProductModel {  Name = "Pedigree Chicken",  Category="Food", Brand = "Pedigree", Weight = "3kg", Price = "Rs 5390.00", Image = "food_vege.png", Tag = "Bella", TagColor = "#FFF4D2"  },
            new ProductModel { Name = "BlackHawk Puppy Lamb &", Brand = "BlackHawk", Weight = "20kg", Price = "Rs 36500.00", Image = "food_lomb.png", Tag = "Roudy", TagColor = "#CED4EC",  Category="Food" },
            new ProductModel {  Name = "Royal Canin Labrador& Vege", Brand = "Royal Canin", Weight = "3kg", Price = "Rs 11,450.00", Image = "food_royal.png", Tag = "Furry", TagColor = "#F9ECE4",Category="Food" },
           
            //Vet Items
            new ProductModel { Name = "Flea & Tick Spray", Category="Vet Items", Brand = "VetCare", Weight = "210ml", Price = "Rs 700.00", Image = "shampoo_vet.png", Tag = "Furry", TagColor = "#F9ECE4" },
            new ProductModel { Name = "Orondo Spray", Category="Vet Items", Brand = "VetCare", Weight = "250ml", Price = "Rs 2800.00", Image = "orondo_vet.png", Tag = "Bella", TagColor = "#FFF4D2" },
            new ProductModel { Name = "Nexgard-Afoxolaner", Category="Vet Items", Brand = "VetCare", Weight = "136mg", Price = "Rs 3480.00", Image = "tablet.png", Tag = "Roudy", TagColor = "#CED4EC" },
            new ProductModel { Name = "Petro Mange Cream", Category="Vet Items", Brand = "VetCare", Weight = "70g", Price = "Rs 650.00", Image = "cream.png", Tag = "Furry", TagColor = "#F9ECE4" },


            //Accessories
             new ProductModel { Name = "Dog Collar", Category="Accessories", Brand = "PetCo", Weight = "Adjustable", Price = "Rs 1390.00", Image = "s_collar.png", Tag = "Furry", TagColor = "#F9ECE4" },
             new ProductModel { Name = "Warm Fleece vest", Category="Accessories", Brand = "PetCo", Weight = "Adjustable", Price = "Rs 1780.00", Image = "s_fleece.png", Tag = "Bella", TagColor = "#FFF4D2" },
             new ProductModel { Name = "PetNail Clipper", Category="Accessories", Brand = "PetCo", Weight = "Adjustable", Price = "Rs 900.00", Image = "nail.png", Tag = "Roudy", TagColor = "#CED4EC" },
             new ProductModel { Name = "Flea Comb", Category="Accessories", Brand = "PetCo", Weight = "Adjustable", Price = "Rs 285.00", Image = "flea.png", Tag = "Furry", TagColor = "#F9ECE4" },


             //IOT Devices
            new ProductModel { Name = "Automatic Pet Feeder", Category="IOT Devices", Brand = "SmartPet", Weight = "2kg", Price = "Rs 24489.00", Image = "pet_feeder.png", Tag = "Furry", TagColor = "#F9ECE4" },
            new ProductModel { Name = "GPS Pet Tracker", Category="IOT Devices", Brand = "SmartPet", Weight = "3kg", Price = "Rs 10580.00", Image = "gps_tracker.png", Tag = "Bella", TagColor = "#FFF4D2"  },
            new ProductModel { Name = "Fi Smart Collar", Category="IOT Devices", Brand = "SmartPet", Weight = "120g", Price = "Rs 9200.00", Image = "smart_coller.png",  Tag = "Roudy", TagColor = "#CED4EC"},
            new ProductModel { Name = "Petcube Pet Camera", Category="IOT Devices", Brand = "SmartPet", Weight = "1.5kg", Price = "Rs 15965.00", Image = "pet_camera.png", Tag = "Furry", TagColor = "#F9ECE4" },
        };

        // Top Selling
        AllTopSelling = new List<ProductModel>
        {
             //Food Items
            new ProductModel { Name = "Rottweiler Puppy", Category="Food", Brand = "Royal Canin", Weight = "3kg",Image = "food_royal.png" , Price="Rs 11,450"},
            new ProductModel { Name = " Josera", Brand = "Josera Mini Deluxe", Weight = "900g",  Image = "mini.png",  Category="Food" ,Price="Rs 2900"},
            new ProductModel {Name = "Happy Dog Supreme Young", Brand = "Junior Original", Weight = "4kg",  Image = "had_young.png",   Category="Food", Price="Rs 980"},

            //Vet Items
            new ProductModel {Category="Vet Items",Name = "Flea & Tick Removal Shampoo", Brand = "Wet Dog", Weight = "210ml",  Image = "shampoo_vet.png",Price="Rs 700"},
            new ProductModel {Category="Vet Items",Name = "Stress Powder", Brand = "Vetzyme", Weight = "150g",  Image = "stress.png", Price="Rs 500"},
            new ProductModel {Category="Vet Items",Name = "Spot On", Brand = "Frontline", Weight = "268mg",  Image = "spoton.png", Price="Rs 950"},

            //Accessories
             new ProductModel {Category="Accessories",Name = "Cotton Fabric Pet Bed", Brand = "Frontline", Image = "bed.png",Price="Rs 15,450"},
             new ProductModel {Category="Accessories",Name = "Flea Comb", Brand = "Frontline", Image = "flea.png",Price="Rs 285"},
             new ProductModel {Category="Accessories",Name = "Dog Raincoat", Brand = "Frontline", Image = "raincoat.png",Price="Rs 2000"},

            //iot devices
            new ProductModel { Name = "Fi Smart Collar", Category="IOT Devices", Brand = "Fi",  Image = "smart_coller.png" ,Price="Rs 9200"},
            new ProductModel { Name = "PetCube Bites 2 Lite", Category="IOT Devices", Brand = "PetCube",  Image = "petcube_bites.png", Price="Rs 8000" },
            new ProductModel { Name = "PetCube Plat 2", Category="IOT Devices", Brand = "PetCUbe",  Image = "pet_play.png", Price="Rs 9000" }
        };
    }

    private void OnCategoryTapped(object sender, TappedEventArgs e)
    {
        if (e.Parameter is string category)
        {
            FilterData(category);
            UpdateCategoryUI(category);
        }
    }

    private void FilterData(string category)
    {
        RecommendedTitle.Text = $"Recommended {category}";
        TopSellingTitle.Text = $"Top Selling {category}";


        RecommendedProducts.Clear();
        var filteredRec = AllRecommended.Where(p => p.Category == category).ToList();
        foreach (var item in filteredRec) RecommendedProducts.Add(item);


        TopSellingProducts.Clear();
        var filteredTop = AllTopSelling.Where(p => p.Category == category).ToList();
        foreach (var item in filteredTop) TopSellingProducts.Add(item);
    }

    private void UpdateCategoryUI(string selected)
    {

        FoodFrame.BackgroundColor = Color.FromArgb("#E8E8E8");
        VetFrame.BackgroundColor = Color.FromArgb("#E8E8E8");
        AccFrame.BackgroundColor = Color.FromArgb("#E8E8E8");
        IotFrame.BackgroundColor = Color.FromArgb("#E8E8E8");


        switch (selected)
        {
            case "Food": FoodFrame.BackgroundColor = Color.FromArgb("#77AE99"); break;
            case "Vet Items": VetFrame.BackgroundColor = Color.FromArgb("#77AE99"); break;
            case "Accessories": AccFrame.BackgroundColor = Color.FromArgb("#77AE99"); break;
            case "IOT Devices": IotFrame.BackgroundColor = Color.FromArgb("#77AE99"); break;
        }
    }

    private async void OnProductSelected(object? sender, TappedEventArgs e)
    {

        var product = e.Parameter as ProductModel;

        if (product != null)
        {

            await Navigation.PushAsync(new ProductDetailPage(product));
        }
    }
    private async void Retail_Store(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RetailStore());
    }
    private async void btn_store(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CartPage());
    }
}