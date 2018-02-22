using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace KeggerBot
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            logo.Source = ImageSource.FromFile("SogetiKegBot.Droid/Resources/drawable/beer1.png");
        }

        void Login_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new LoginInfo());
        }

        void CreateAccount_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new CreateAccountPage());
        }
    }
}
