using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin2DotNet.Controls;

using MongoDB.Driver;

using RestSharp;

namespace ElearningApp
{
    public partial class LoginView : MaterialForm
    {
        public LoginView()
        {
            InitializeComponent();
            loginButton.ForeColor = Color.Green;
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            //TODO - connect to users db (mongoDB)
            var client = new MongoClient("mongodb+srv://<username>:<password>@<cluster-address>/test?w=majority");
            var database = client.GetDatabase("test");


            //initialize authentication service
            var authClient = new RestClient("localhost");
            var request = new RestRequest("api/item/", Method.Get);
            var queryResult = client.Execute<List<Items>>(request).Data;

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //TODO - authenticate user

            //TODO - open main menu
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            if (!ViewTools.IsFormOpened<CreateUserView>())
            {
                var cardView = new CreateUserView(_serviceCollection);
                cardView.Show();
            }
            else
            {
                ViewTools.GetOpenedForm<CreateUserView>().Focus();
            }
        }

        
    }
}
