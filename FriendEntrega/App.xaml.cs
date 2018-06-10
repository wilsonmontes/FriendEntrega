using FriendEntrega.Data;
using FriendEntrega.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace FriendEntrega
{
    

    public partial class App : Application
	{
        private static FriendDataBase database;

        public static FriendDataBase Database
        {
            get
            {
                if (database == null)
                {
                    database = new FriendDataBase(DependencyService.Get<IfileHelper>().GetLocalFilePath("friendsdb.db3"));
                }
                return database;
            }
        }
        public App ()
		{
			InitializeComponent();

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
