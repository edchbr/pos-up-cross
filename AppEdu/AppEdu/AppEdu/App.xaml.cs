using AppEdu.Service;
using AppEdu.ViewModel.Base;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppEdu
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            BuildDepedences();

            InitNavigation();

        }

        private async void InitNavigation()
        {
            var navigationService = ViewModelLocator.Instance.Resolve<INavigationService>();
            await navigationService.Initialize();
        }

        private void BuildDepedences()
        {
            ViewModelLocator.Instance.Build();
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
