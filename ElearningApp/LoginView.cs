
using ElearningModels.Interfaces;

using MaterialSkin2DotNet.Controls;

using MongoDB.Bson;
using MongoDB.Driver;

using RestSharp;

namespace ElearningApp
{
    public partial class LoginView : MaterialForm
    {
        public RestClient _authClient { get; set; }

        public MongoClient _dbClient { get; set; }

        public LoginView(RestClient authClient)
        {
            InitializeComponent();

            _authClient = authClient;
            loginButton.ForeColor = Color.Green;
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            MongoClient dbClient = new MongoClient(@"mongodb://developer:deve-1992@localhost:27017/");

            var dbList = dbClient.ListDatabases().ToList();

            _dbClient = dbClient;

        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            //TODO - authenticate user with authentication microservice
            /* var request = new RestRequest()
                .AddQueryParameter("username", usernameTextBox.Text)
                .AddQueryParameter("password", passwordTextBox.Text);
             var response = await _authClient.PostAsync<Result<IUser, string>>(request);
             if (response.IsErr)
             {
                 MessageBox.Show(response.Err, "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
 */
            ElearningModels.Models.Users.AdminModel admin = new ElearningModels.Models.Users.AdminModel()
            {
                Id = ObjectId.GenerateNewId(),
                Username = usernameTextBox.Text,
                Password = passwordTextBox.Text,
                Icon = @"C:\Users\mpampis\Desktop\emultisoftlogo-e1573645677182.png",
            };

            //_dbClient.GetDatabase("elearning").CreateCollection("users");
            _dbClient.GetDatabase("elearning").GetCollection<IUser>("users").InsertOne(admin);
            var user = _dbClient.GetDatabase("elearning").GetCollection<IUser>("users").Find<IUser>(_ => true).ToList();

            //TODO - open main menu
            if (!ViewTools.IsFormOpened<MainMenu>())
            {
                var cardView = new MainMenu(admin);
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
