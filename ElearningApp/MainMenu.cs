
using System.Data;

using ElearningModels.Interfaces;

using MaterialSkin2DotNet.Controls;

namespace ElearningApp
{
    public partial class MainMenu : MaterialForm
    {
        IUser _user;

        public MainMenu(IUser user)
        {
            InitializeComponent();
            _user = user;
            if (!string.IsNullOrEmpty(_user.Icon))
            { 
                profileButton.Icon = Image.FromFile(_user.Icon);
            }

        }



       
    }
}