
using  PetMauiApp.Models;
using System.Collections.ObjectModel;
using static PetMauiApp.Models.VetPageModel;

namespace PetMauiApp.Pages;

public partial class VetPage : ContentPage
{
    public ObservableCollection<Vet> RecommendedVets { get; set; } = new();
   
    public ObservableCollection<NearbyPlace> NearbyPlaces { get; set; } = new();

    private List<Vet> AllRecommended = new();
    private List<NearbyPlace> AllNearby = new();

    private string _selectedCategory = "Veterinary";

    public VetPage()
    {
        InitializeComponent();
        LoadData();
        FilterData("Veterinary");
    }

    public void LoadData()
    {
        AllNearby = new List<NearbyPlace>
        {
            // Veterinary
            new NearbyPlace { Category = "Veterinary", Name = "Dr. Nambuvan",
                Specialization = "Bachelor of Veterinary Science",
                Rating = "5.0 (100 reviews)", Experience = "10 years",
                Distance = "📍 2.5 km", Schedule = "🕒 Mon-Fri: 8am - 5pm",
                Status = "OPEN", ImageUrl = "dr.png" },

            new NearbyPlace { Category = "Veterinary", Name = "Dr. Sambuvan",
                Specialization = "Veterinary Dentist",
                Rating = "5.0 (100 reviews)", Experience = "4 years",
                Distance = "📍 2 km", Schedule = "🕒 Mon-Fri: 8am - 5pm",
                Status = "OPEN", ImageUrl = "dog.png" },

            // Grooming
            new NearbyPlace { Category = "Grooming", Name = "Comb and Collar",
                Specialization = "Pet Grooming Salon",
                Rating = "5.0 (100 reviews)", Experience = "5 years",
                Distance = "📍 1 km", Schedule = "🕒 Mon-Fri: 9am - 6pm",
                Status = "OPEN", ImageUrl = "grrom.png" },

            new NearbyPlace { Category = "Grooming", Name = "Cosmo Dog Cares",
                Specialization = "Dog Spa & Grooming",
                Rating = "4.9 (90 reviews)", Experience = "3 years",
                Distance = "📍 3 km", Schedule = "🕒 Mon-Sat: 9am - 7pm",
                Status = "CLOSED", ImageUrl = "groom_cares.png" },

            // Boarding
            new NearbyPlace { Category = "Boarding", Name = "Tails of the City",
                Specialization = "Pet Boarding & Daycare",
                Rating = "5.0 (100 reviews)", Experience = "7 years",
                Distance = "📍 4 km", Schedule = "🕒 Mon-Fri: 7am - 8pm",
                Status = "OPEN", ImageUrl = "board_city.png" },

            new NearbyPlace { Category = "Boarding", Name = "Cutie Paws",
                Specialization = "Pet Hotel & Boarding",
                Rating = "5.0 (100 reviews)", Experience = "5 years",
                Distance = "📍 2 km", Schedule = "🕒 Mon-Fri: 8am - 6pm",
                Status = "OPEN", ImageUrl = "board_paws.png" },
        };

      
        AllRecommended = new List<Vet>
        {
            // Veterinary
            new Vet { Category = "Veterinary", Name = "Dr. Nambuvan",
                Specialization = "Bachelor of Veterinary Science",
                Rating = "5.0 (100 reviews)", Experience = "10 years",
                Distance = "📍 2.5 km", Schedule = "🕒 Mon-Fri: 9am - 5pm",
                Status = "OPEN", ImageUrl = "vet_puppy.png" },

            new Vet { Category = "Veterinary", Name = "Dr. Michael Smith",
                Specialization = "Bachelor of Veterinary Science",
                Rating = "4.6 (80 reviews)", Experience = "8 years",
                Distance = "📍 5 km", Schedule = "🕒 Mon-Sat: 10am - 6pm",
                Status = "OPEN", ImageUrl = "doctor.png" },

            new Vet { Category = "Veterinary", Name = "Dr. Emily Davis",
                Specialization = "Bachelor of Veterinary Science",
                Rating = "4.9 (150 reviews)", Experience = "12 years",
                Distance = "📍 3 km", Schedule = "🕒 Tue-Sun: 8am - 4pm",
                Status = "OPEN", ImageUrl = "doctor_vet.png" },

            // Grooming
            new Vet { Category = "Grooming", Name = "Dirty Paws Dog Spa",
                Specialization = "Full Grooming & Spa",
                Rating = "5.0 (100 reviews)", Experience = "6 years",
                Distance = "📍 2 km", Schedule = "🕒 Mon-Fri: 8am - 5pm",
                Status = "OPEN", ImageUrl = "groom_spa.png" },

            new Vet { Category = "Grooming", Name = "Happy Paws Grooming",
                Specialization = "Pet Styling & Grooming",
                Rating = "4.8 (120 reviews)", Experience = "4 years",
                Distance = "📍 3 km", Schedule = "🕒 Mon-Sat: 9am - 6pm",
                Status = "CLOSED", ImageUrl = "groom_bone.png" },

            // Boarding
            new Vet { Category = "Boarding", Name = "Silver Paw Lodge",
                Specialization = "Luxury Pet Boarding",
                Rating = "5.0 (750 reviews)", Experience = "8 years",
                Distance = "📍 5 km", Schedule = "🕒 Mon-Fri: 8am - 8pm",
                Status = "OPEN", ImageUrl = "board_lodge.png" },

            new Vet { Category = "Boarding", Name = "Cozy Paws Inn",
                Specialization = "Pet Boarding & Care",
                Rating = "4.7 (200 reviews)", Experience = "5 years",
                Distance = "📍 4 km", Schedule = "🕒 Mon-Fri: 7am - 7pm",
                Status = "CLOSED", ImageUrl = "board_dog.png" },
        };
    }
    private void OnCategoryTapped(object sender, TappedEventArgs e)
    {
        if (e.Parameter is string category)
        {
            _selectedCategory = category;
            FilterData(category);
            UpdateCategoryUI(category);
        }
    }

    private void FilterData(string category)
    {
      
        NearbyTitle.Text = $"Nearby {category}";
        RecommendedTitle.Text = $"Recommended {category}";

      
        NearbyPlaces.Clear();
        foreach (var place in AllNearby.Where(n => n.Category == category))
            NearbyPlaces.Add(place);
        NearbyList.ItemsSource = NearbyPlaces;

       
        RecommendedVets.Clear();
        foreach (var vet in AllRecommended.Where(v => v.Category == category))
            RecommendedVets.Add(vet);
        RecommendedList.ItemsSource = RecommendedVets;
    }

    private void UpdateCategoryUI(string selected)
    {
       
        VetFrame.BackgroundColor = Color.FromArgb("#E8E8E8");
        GroomFrame.BackgroundColor = Color.FromArgb("#E8E8E8");
        BoardFrame.BackgroundColor = Color.FromArgb("#E8E8E8");

       
        switch (selected)
        {
            case "Veterinary": VetFrame.BackgroundColor = Color.FromArgb("#77AE99"); break;
            case "Grooming": GroomFrame.BackgroundColor = Color.FromArgb("#77AE99"); break;
            case "Boarding": BoardFrame.BackgroundColor = Color.FromArgb("#77AE99"); break;
        }
    }
}