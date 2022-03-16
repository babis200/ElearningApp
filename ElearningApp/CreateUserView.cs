
using ElearningModels.Interfaces;

using MaterialSkin2DotNet.Controls;

namespace ElearningApp
{
    public partial class CreateUserView : MaterialForm
    {
        IUser _user;

        public CreateUserView(IUser user = null)
        {
            InitializeComponent();
            _user = user;
        }

        private void createButton_Click(object sender, EventArgs e)
        {

            //only teachers and admins can create students
            //only admins can create teachers
            //students cant create new users
            //if it is accesed before/without login only a guest can be created

            if (_user is null)
            {

            }



            //create user call

            //show result and close window
        }
    }
}
