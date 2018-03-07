using Xamarin.Forms;
using System;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace KeggerBot
{
    public partial class KeggerBotPage : ContentPage
    {
        public KeggerBotPage()
        {
            InitializeComponent();

            //images
            logo.Source = ImageSource.FromFile("SogetiKegBot.Droid/Resources/drawable/beer1.png");
            lefttap.Source = ImageSource.FromFile("SogetiKegBot.Droid/Resources/drawable/TwoBrothers.jpg");
            righttap.Source = ImageSource.FromFile("SogetiKegBot.Droid/Resources/drawable/bluemoon.jpg");

            //labels
            ontap.FontAttributes = FontAttributes.Italic;
            ontap.FontSize = 24;

            //onTap for Image
            var tapImage = new TapGestureRecognizer();
            tapImage.Tapped += LeftTapImage_Tapped;
            lefttap.GestureRecognizers.Add(tapImage);

            var SecondtapImage = new TapGestureRecognizer();
            SecondtapImage.Tapped += RightTapImage_Tapped;
            righttap.GestureRecognizers.Add(SecondtapImage);

            void LeftTapImage_Tapped(object sender, EventArgs e){
                AlertLeftTap(sender,e);
            }

            void RightTapImage_Tapped(object sender, EventArgs e)
            {
                AlertRightTap(sender, e);
            }

        }

        async void AlertLeftTap(object sender, EventArgs e){
            var clicked = await DisplayAlert("Two Brothers Beer", "Type: Hefeweizen \n\nDescription: Ebel's Weiss beer is a very traditional German Hefeweizen that is naturally unfiltered. It has wonderful malt sweetness and a soft aroma of clove, vanilla, and banana. This deep golden colored weiss will make you think you are in Bavaria. ", "Pour This Beer!", "No Thanks");
            if(clicked.Equals(true)){
                await DisplayAlert("Pouring Two Brothers Beer...", "Pouring Now", "OK");
            }
            else{
            }
        }

        async void AlertRightTap(object sender, EventArgs e)
        {
            var clicked = await DisplayAlert("Blue Moon", "Type: Belgian-style witbier \n\nDescription: Blue Moon Belgian White Ale. Brewed with oats for creaminess and spiced with the perfect combination of orange peel and coriander. An unfiltered wheat ale spiced in the Belgian tradition for an uncommonly smooth taste. ", "Pour This Beer!", "No Thanks");
            //keep track of how much beer is being poured.
            if (clicked.Equals(true))
            {
                await DisplayAlert("Pouring Blue Moon...", "Pouring Now", "OK");
            }
            else
            {
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

