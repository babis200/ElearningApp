using ElearningModels;

using ElearningServices;

using MaterialSkin2DotNet.Controls;
using static ElearningApp.AppEnums;

namespace ElearningApp
{
    public partial class CourseView : MaterialForm
    {
        CourseModel _course;

        ServiceCollection _services;

        public CourseView(ServiceCollection services ,CourseModel course)
        {
            InitializeComponent();
            subjectsDGV.AutoGenerateColumns = false;
            _services = services;
            _course = course;

        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            this.Text = _course.Name;
            UpdateView();

            /*foreach (var subject in _course.Subjects)
            {
            }*/
        }

        private void UpdateView()
        {
            teachersLabel.Text = string.Join(',', _course.Teachers);
            descriptionContentLabel.Text = _course.Description;



            subjectsDGV.DataSource = null;
            subjectsDGV.DataSource = _course.Subjects;
        }

        private void editCourseButton_Click(object sender, EventArgs e)
        {
            if (!ViewTools.IsFormOpened<AddEditCourseView>())
            {
                var courseView = new AddEditCourseView(Work.Edit, _services, _course, UpdateView);
                courseView.ShowDialog();
            }
            else
            {
                ViewTools.GetOpenedForm<AddEditCourseView>().Focus();
            }
        }
    }
}
