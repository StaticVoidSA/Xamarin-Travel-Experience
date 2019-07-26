using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinExperienceTravelApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LoginBtn_Clicked(object sender, EventArgs e)
        {
            bool isEmailEmpty = string.IsNullOrEmpty(emailTxt.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(passwordTxt.Text);

            if (isEmailEmpty || isPasswordEmpty)
            {
                
            }
            else
            {
                Navigation.PushAsync(new HomePage());
            }
        }
    }
}
