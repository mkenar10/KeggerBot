using System;
using System.Collections.Generic;
using System.Net.Http;
using Xamarin.Forms;

namespace KeggerBot
{
    public partial class LoginInfo : ContentPage
    {
        public LoginInfo()
        {
            InitializeComponent();

            logo.Source = ImageSource.FromFile("SogetiKegBot.Droid/Resources/drawable/beer1.png");
        }

        void Login_Clicked(object sender, System.EventArgs e)
        {
            var user = username.Text.ToString();
            var pass = password.Text.ToString();
            sample.Text = user + " " + pass;

           // HttpClient httpClient = new HttpClient();
            //var response = async httpClient.GetAsync(new Uri("HTTP://KEGGERBOTAPI.AZUREWEBSITES.NET/API"));




            //go to main page
        }
    }
}
