using PetMauiApp.Models;
using System.Collections.ObjectModel;
namespace PetMauiApp.Pages;

public partial class AddDevice : ContentPage
{
	public ObservableCollection<DeviceModel> Devices { get; set; }
	public AddDevice()
	{
		InitializeComponent();
		LoadData();
		BindingContext = this;
    }
	void LoadData() {
		Devices = new ObservableCollection<DeviceModel>
	 {
		 new DeviceModel{ Name ="Smart Collar", Image="smart_coller.png", IsSelected=true},
		 new DeviceModel{ Name ="Pet Feeder", Image="pet_feeder.png", IsSelected=false},
		 new DeviceModel{ Name ="GPS Tracker", Image="gps_tracker.png", IsSelected=false},
		 new DeviceModel{ Name ="Pet Camera", Image="pet_camera.png", IsSelected=false},
		 new DeviceModel{ Name ="PetCube Play", Image="pet_play.png", IsSelected=false},
		 new DeviceModel{ Name ="PetCubes bites", Image="petcube_bites.png", IsSelected=false},
		 new DeviceModel{ Name ="GPSPet Tracker", Image="gps_tracker.png", IsSelected=false},
	 };

	}
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

}
