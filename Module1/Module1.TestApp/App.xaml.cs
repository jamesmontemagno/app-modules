using ComponentApp.SharedInterface;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Module1.TestApp
{
    public partial class App : Application
    {
        public static Module Module { get; private set; }
        public App()
        {
            InitializeComponent();
            Module = new Module();
            var navigation = new NavigationPage(new Page1());
            MainPage = navigation;
            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
