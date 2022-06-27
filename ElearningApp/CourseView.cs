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

        SubjectModel _selectedSubject;

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

        private void examButton_Click(object sender, EventArgs e)
        {
            //TODO - agregate questions from subject exams
        }

        private void readSubjectButton_Click(object sender, EventArgs e)
        {
            _selectedSubject = GetSelectedSubject();
            if (!ViewTools.IsFormOpened<AddEditSubjectView>())
            {
                var subjectView = new AddEditSubjectView(Work.Preview, _selectedSubject, _services, UpdateView);
                subjectView.ShowDialog();
            }
            else
            {
                ViewTools.GetOpenedForm<AddEditSubjectView>().Focus();
            }
        }

        private void examSubjectButton_Click(object sender, EventArgs e)
        {
            _selectedSubject = GetSelectedSubject();
            if (!ViewTools.IsFormOpened<ExaminationView>())
            {
                var examView = new ExaminationView(_services.ExamService, _selectedSubject.Exam);
                examView.ShowDialog();
            }
            else
            {
                ViewTools.GetOpenedForm<ExaminationView>().Focus();
            }
        }

        SubjectModel GetSelectedSubject()
        {
            Guid id = Guid.Empty;
            if (subjectsDGV.CurrentRow != null)
            {
                id = Guid.Parse(subjectsDGV.CurrentRow.Cells["Id"].Value.ToString());
            }

            return _course?.Subjects?.FirstOrDefault(x => x.Id == id);
        }
    }
}
