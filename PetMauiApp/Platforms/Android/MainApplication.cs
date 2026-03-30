using Android.App;
using Android.Runtime;
using Firebase;
using Plugin.FirebasePushNotifications.Platforms;
namespace PetMauiApp
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        public override void OnCreate()
        {
            base.OnCreate();

            try
            {
                var app = FirebaseApp.InitializeApp(this);
                if (app == null)
                {
                    System.Diagnostics.Debug.WriteLine("FirebaseApp.InitializeApp returned null in Application.OnCreate. Check google-services.json and ApplicationId.");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"Firebase initialized in Application: {app.Name}");
                }
            }
            catch (System.Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Firebase initialization failed in Application.OnCreate: {ex}");
            }
        }
    }
}
