
using MaterialSkin2DotNet.Controls;

namespace ElearningApp
{
    public partial class UserView : MaterialForm
    {

        public UserView()
        {
            InitializeComponent();


        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            if (!ViewTools.IsFormOpened<CreateUserView>())
            {
                var cardView = new CreateUserView();
                cardView.Show();
            }
            else
            {
                ViewTools.GetOpenedForm<CreateUserView>().Focus();
            }
        }
    }
}
