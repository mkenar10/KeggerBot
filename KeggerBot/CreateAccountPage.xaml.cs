using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;

namespace KeggerBot
{
    public partial class CreateAccountPage : ContentPage
    {
        public CreateAccountPage()
        {
            InitializeComponent();

            logo.Source = ImageSource.FromFile("SogetiKegBot.Droid/Resources/drawable/beer1.png");
        }

        // void SaveInfo_Clicked(object sender, System.EventArgs e)
        // {
        // string firstname = fname.Text.ToString();
        // string lastname = lname.Text.ToString();
        // string username = uname.Text.ToString();
        // string password = pword.Text.ToString();

        // AddUser(firstname, lastname, username, password);

        // string connectionString = null;
        // SqlConnection connection;
        // SqlCommand command;
        // string sql = null;

        // connectionString = "Data Source=sogetikeggerbot;Initial Catalog=KeggerBot;User ID=KeggerBot;Password=Password1";
        // sql = "SELECT * FROM dbo.Users";
        // connection = new SqlConnection(connectionString);
        // try{
        //connection.Open();
        //    command = new SqlCommand(sql,connection);
        // DisplayAlert("Connection Successful", "YAY!", "OK");
        // connection.Close();
        // }
        // catch(Exception e){
        //  DisplayAlert("NO COnnection","No","OK");
        // }
        //check to see if user and password match in database.

        //SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=database.sqlite;Version=3;");

        // SQLiteCommand sqlite_conn.Open();




        // Navigation.PushModalAsync(new KeggerBotPage());

        async void AddUser_Clicked(object sender, System.EventArgs e)
        {
            HttpClient client = new HttpClient();

            string url = @"http://keggerbotapi.azurewebsites.net/api/user/AddUser";

            string firstname = fname.Text.ToString();
            string lastname = lname.Text.ToString();
            string username = uname.Text.ToString();
            string password = pword.Text.ToString();


            var user = new User
            {
                FirstName = firstname,
                LastName = lastname,
                UserName = username,
                Password = password
            };

            var uri = new Uri(string.Format(url, string.Empty));

            var json = JsonConvert.SerializeObject(user);

            HttpResponseMessage response = null;

            try
            {
                response = await client.PostAsync(uri, new StringContent(json));

                if (response.IsSuccessStatusCode)
                {
                    await DisplayAlert("Alert", "You have been added! Please log in.", "OK");
               }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }





            // var content = JsonConvert.SerializeObject(user);
            //HttpResponseMessage response = await client.PostAsync(url, user);
            // var response = client.PostAsync(url, new StringContent(new JavaScriptSerializer().Serialize(user),Enc))
            // await client.PostAsync(url, new StringContent(content));
            // await DisplayAlert("Alert", "You have been added! Please log in.", "OK");
        }
    }
}

       // public void AddUser(string username, string password, string firstname, string lastname)
        //{
        //    HttpClient client = new HttpClient();

        //}


    

        

