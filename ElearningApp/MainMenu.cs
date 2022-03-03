
using System.Data;

using MaterialSkin2DotNet.Controls;

namespace ElearningApp
{
    public partial class MainMenu : MaterialForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }


        private void materialButton1_Click_1(object sender, EventArgs e)
{
            var vatView = new CourseView(_serviceCollection);
            vatView.Show();
        }
    }
}