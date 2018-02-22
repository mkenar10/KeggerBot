using Xamarin.Forms;
using System;

namespace KeggerBot
{
    public partial class KeggerBotPage : ContentPage
    {
        public KeggerBotPage()
        {
            InitializeComponent();

            //images
            logo.Source = ImageSource.FromFile("SogetiKegBot.Droid/Resources/drawable/beer1.png");
            lefttap.Source = ImageSource.FromFile("SogetiKegBot.Droid/Resources/drawable/guinness.jpg");
            righttap.Source = ImageSource.FromFile("SogetiKegBot.Droid/Resources/drawable/bluemoon.jpg");

            //labels
            ontap.FontAttributes = FontAttributes.Italic;
            ontap.FontSize = 24;

            //onTap for Image
            var tapImage = new TapGestureRecognizer();
            tapImage.Tapped += tapImage_Tapped;
            lefttap.GestureRecognizers.Add(tapImage);

            //add measurement of how much poured here.
            void tapImage_Tapped(object sender, EventArgs e){
                DisplayAlert("Alert","Your pour: ","OK");
            }

        }

        //public void newdrinker(object sender, EventArgs e){
         //   Navigation.PushModalAsync(new NewDrinkerPage());
        //}

        //public void pourBeer(object sender, EventArgs e){
           // DisplayAlert("Alert","Here is some beer!","OK");
        //} 


        }
    }

