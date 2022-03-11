using ElearningModels.Interfaces;

using MaterialSkin2DotNet.Controls;

namespace ElearningApp
{
    public partial class UserView : MaterialForm
    {
        IUser _user;

        public UserView(IUser user)
        {
            InitializeComponent();
            _user = user;

        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            if (!ViewTools.IsFormOpened<CreateUserView>())
            {
                var cardView = new CreateUserView(_user);
                cardView.Show();
            }
            else
            {
                ViewTools.GetOpenedForm<CreateUserView>().Focus();
            }
        }
    }
}
