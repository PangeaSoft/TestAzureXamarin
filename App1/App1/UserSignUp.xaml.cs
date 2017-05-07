using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserSignUp : ContentPage
	{
		public UserSignUp ()
		{
			InitializeComponent ();

            btnStart.IsEnabled = false;
            entryUserName.TextChanged += delegate
            {
                if (entryUserName.Text.Trim() != string.Empty)
                    btnStart.IsEnabled = true;
                else
                    btnStart.IsEnabled = false;
            };

		}

        public void NavigateToQuiz(object sender, EventArgs args)
        {
            AppSettings.UserName = entryUserName.Text;

        }
	}
}
