using System;
using System.Collections.Generic;

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

        void SaveInfo_Clicked(object sender, System.EventArgs e)
        {
            string connectionString = null;
           // SqlConnection connection;
           // SqlCommand command;
            string sql = null;

            connectionString = "Data Source=sogetikeggerbot;Initial Catalog=KeggerBot;User ID=KeggerBot;Password=Password1";
            sql = "SELECT * FROM dbo.Users";
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




            Navigation.PushModalAsync(new KeggerBotPage());
        }

        static private string GetConnectionString(){
            return "Data Source=;Initial Catalog=;" + "Integrated Security=true;";
        }
    }
}
