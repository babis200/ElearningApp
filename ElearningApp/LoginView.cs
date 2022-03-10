using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using ElearningModels.Interfaces;
using MaterialSkin2DotNet.Controls;
using MongoDB.Driver;
using RestSharp;
using static ElearningApp.AppEnums;

namespace ElearningApp
{
    public partial class LoginView : MaterialForm
    {
        public RestClient _authClient { get; set; }

        public LoginView(RestClient authClient)
        {
            InitializeComponent();

            _authClient = authClient;
            loginButton.ForeColor = Color.Green;
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            //TODO - connect to users db (mongoDB)
            var client = new MongoClient("mongodb+srv://<username>:<password>@<cluster-address>/test?w=majority");
            var database = client.GetDatabase("test");

            //initialize authentication service
           


        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            //TODO - authenticate user
            var request = new RestRequest()
               .AddQueryParameter("username", usernameTextBox.Text)
               .AddQueryParameter("password", passwordTextBox.Text);
            var response = await _authClient.PostAsync<Result<IUser, string>>(request);
            if (response.IsErr)
            {
                MessageBox.Show(response.Err, "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //TODO - open main menu
            if (!ViewTools.IsFormOpened<CreateUserView>())
            {
                var cardView = new MainMenu(response.Ok);
                cardView.Show();
            }
            else
            {
                ViewTools.GetOpenedForm<MainMenu>().Focus();
            }
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            if (!ViewTools.IsFormOpened<CreateUserView>())
            {
                var cardView = new CreateUserView(/*authentication microservice`*/);
                cardView.Show();
            }
            else
            {
                ViewTools.GetOpenedForm<CreateUserView>().Focus();
            }
        }

        
    }
}
