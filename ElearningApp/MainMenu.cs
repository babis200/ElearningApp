using ElearningModels;

using ElearningServices;

using MaterialSkin2DotNet.Controls;

using System.Windows.Forms;

using static ElearningApp.AppEnums;

namespace ElearningApp
{
    public partial class MainMenu : MaterialForm
    {
        ServiceCollection _services;

        List<CourseModel> _courses;

        CourseModel _selectedCourse;

        public MainMenu(ServiceCollection services)
        {
            InitializeComponent();
            courseDGV.AutoGenerateColumns = false;
            _services = services;
            _courses = _services.CourseService.GetAll();

            UpdateView();
        }


        private void UpdateView()
        {
            courseDGV.DataSource = null;
            courseDGV.DataSource = _courses;
        }
       
        private void newCourseButton_Click(object sender, EventArgs e)
        {
            if (!ViewTools.IsFormOpened<AddEditCourseView>())
            {
                var courseView = new AddEditCourseView(Work.Add, _services, new CourseModel(), UpdateView);
                courseView.Show();
            }
            else
            {
                ViewTools.GetOpenedForm<AddEditCourseView>().Focus();
            }
        }

        private void courseDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedCourse = GetSelectedCourse();

            if (!ViewTools.IsFormOpened<CourseView>())
            {
                var subjectView = new CourseView(_services.CourseService, _selectedCourse);
                subjectView.Show();
            }
            else
            {
                ViewTools.GetOpenedForm<CourseView>().Focus();
            }
        }

        CourseModel GetSelectedCourse()
        {
            Guid id = Guid.Empty;
            if (courseDGV.CurrentRow != null)
            {
                id = Guid.Parse(courseDGV.CurrentRow.Cells[0].Value.ToString());
            }

            return _courses.FirstOrDefault(x => x.Id == id);
        }
    }
}