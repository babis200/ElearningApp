
using ElearningServices;

using MaterialSkin2DotNet.Controls;

namespace ElearningApp
{
    public partial class MainMenu : MaterialForm
    {
        ServiceCollection _services;

        public MainMenu(ServiceCollection services)
        {
            InitializeComponent();
            _services = services;
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            if (!ViewTools.IsFormOpened<UserView>())
            {
                var userView = new UserView();
                userView.Show();
            }
            else
            {
                ViewTools.GetOpenedForm<UserView>().Focus();
            }
        }

        private void coursesListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newCourseButton_Click(object sender, EventArgs e)
        {
            if (!ViewTools.IsFormOpened<CourseView>())
            {
                var courseView = new AddEditCourseView(_services.CourseService);
                courseView.Show();
            }
            else
            {
                ViewTools.GetOpenedForm<CourseView>().Focus();
            }
        }
    }
}