using System;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;
using XamarinAllianceApp.Views;

namespace XamarinAllianceApp
{
    public class App : Application
	{
        public App ()
		{
            string mobileServiceClientUrl = "http://xamarinalliancebackend.azurewebsites.net";
            MobileServiceClient Client = new MobileServiceClient(mobileServiceClientUrl);

            // The root page of your application
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

