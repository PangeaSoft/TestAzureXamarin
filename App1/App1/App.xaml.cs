using App1.Droid.ViewModel;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1
{
    public class AppSettings
    {
        public const int QUESTIONS_COUNT = 1;
        public static int CurrentQuestion = 1;
        public static int Score = 0;
        public static string UserName = "";

        private static MobileServiceClient _mobileServiceClient;

        public static MobileServiceClient MobileService
        {
            get
            {
                if (_mobileServiceClient == null)
                    _mobileServiceClient = new MobileServiceClient("https://xamarinfestquiz.azurewebsites.net");
                return _mobileServiceClient;
            }
        }
    }

	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            IMobileServiceTable<XamarinQuiz> xamarinQuizTable = AppSettings.MobileService.GetTable<XamarinQuiz>();

            //XamarinQuiz item = new XamarinQuiz();
            //item.Question = "Icardi tiene que ser el 9?";
            //item.Answer1 = "Obvio!";
            //item.Answer2 = "No";
            //item.Answer3 = "Que entregue a wanda.";
            //item.CorrectAnswer = 1;
            //item.id = "1111-AAAA";

            //xamarinQuizTable.InsertAsync(item);

            MainPage = new App1.MainPage();
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
