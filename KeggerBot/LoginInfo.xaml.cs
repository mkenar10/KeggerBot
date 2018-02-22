using System;
using System.Collections.Generic;

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
    }
}
