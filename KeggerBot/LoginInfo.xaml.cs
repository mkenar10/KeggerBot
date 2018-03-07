using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
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

        public void Login_Clicked(object sender, System.EventArgs e)
        {
            var user = username.Text.ToString();
            var pass = password.Text.ToString();
            //sample.Text = user + " " + pass;

            string url = @"http://keggerbotapi.azurewebsites.net/api/user/GetAllUsers";

            CheckDB(url, user);

        }
        protected async void CheckDB(string url, string user){

            HttpClient client = new HttpClient();
            var uri = new Uri(string.Format(url, string.Empty));

            var response1 = await client.GetAsync(uri);
            if (response1.IsSuccessStatusCode)
            {
                var content = await response1.Content.ReadAsStringAsync();
            }

           // sample.Text = response;

          //string responseString;
          //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);

           // try{
               // using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
               // using (Stream stream = response.GetResponseStream())
               // using (StreamReader reader = new StreamReader(stream))
                   // {
                    //    responseString = await reader.ReadToEndAsync();
                   // }
               
           // }
           // catch(Exception e){
              //  e.ToString();
           //}

            //HttpWebResponse myresponse = (HttpWebResponse)await request.GetResponseAsync();
            //using (var response = await request.GetResponseAsync())
            //{
              //  using (var reader = new StreamReader(response.GetResponseStream()))
              //  {
                 //   responseString = reader.ReadToEnd();

                //}
           // }

           //using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
           //using (Stream stream = response.GetResponseStream())
           //using (StreamReader reader = new StreamReader(stream))
            //{
               // responseString = await reader.ReadToEndAsync();
            //}
            //sample.Text = responseString;

           // if (responseString.Contains(user)){
                //await Navigation.PushModalAsync(new KeggerBotPage());
           // }
            //else{
             //   await DisplayAlert("Alert", "The Username/Password does not match our systems. Please verify that you have created an account and try again. \n\n Drink on! ", "OK");
              //  username.Text = string.Empty;
               // password.Text = string.Empty;
           // }

            //sample.Text = responseString;
        }
    }
}
