using Microsoft.Extensions.Logging;
using Microsoft.Maui.LifecycleEvents;
using Syncfusion.Maui.Core.Hosting;


namespace PetMauiApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
              .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Poppins-Regular.ttf", "PoppinRegular");
                    fonts.AddFont("Poppins-SemiBold.ttf", "PoppinsBold");
                    fonts.AddFont("Poppins-SemiBoldltalic.ttf", "PoppinsBolditalic");
                })
              .RegisterServices();

#if DEBUG
            builder.Logging.AddDebug();

#endif

            return builder.Build();
        }

        private static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
        {
            builder.ConfigureLifecycleEvents(events =>
            {
#if ANDROID
                events.AddAndroid(android =>
                    android.OnCreate((activity, _) =>
                        Firebase.FirebaseApp.InitializeApp(activity)));
#endif
            });

            return builder;
        }
    }
}
