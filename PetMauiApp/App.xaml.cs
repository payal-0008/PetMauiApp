using Microsoft.Extensions.DependencyInjection;
using PetMauiApp.Pages;

namespace PetMauiApp
{
    public partial class App : Application
    {
        public App()
        {

            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}