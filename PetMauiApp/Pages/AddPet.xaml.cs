using PetMauiApp.Models;
using System.Collections.ObjectModel;

namespace PetMauiApp.Pages;

public partial class AddPet : ContentPage
{
	public  ObservableCollection<PetModel> PetModels { get; set; }

	public AddPet()
	{
		InitializeComponent();
		LoadData();
		BindingContext = this;
	}
	void LoadData()
	{
		PetModels = new ObservableCollection<PetModel>
		{
			 new PetModel{ Name ="Bella", Image="dog1.png", Color="#F0BB22"},
			 new PetModel{ Name ="Roudy", Image="dog2.png",Color="#7A86AE"},
			 new PetModel{ Name ="Furry", Image="dog3.png",Color="#E28E69"},
		};
	}
	private async void Btn_Dash(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Dashboard());
	}
}