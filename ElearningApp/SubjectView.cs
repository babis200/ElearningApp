
using ElearningModels;

using ElearningServices;

using MaterialSkin2DotNet.Controls;

namespace ElearningApp
{
    public partial class SubjectView : MaterialForm
    {
        SubjectService _service;
        SubjectModel _subject;
        Action _updateParent;

        public SubjectView(SubjectService service, SubjectModel subject, Action updateParent)
        {
            InitializeComponent();
            _service = service;
            _subject = subject;
            _updateParent = updateParent;
        }

        private void SubjectView_Load(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void UpdateView()
        {
            //Name
            subjectNameTextBox.Text = _subject.Name;
            foreach (var resource in _subject.Resources)
            {
                resourcesDGV.Rows.Add(resource);
            }

            foreach (var exam in _subject.Exams)
            {
                resourcesDGV.Rows.Add(exam);
            }
        }

        private void subjectNameTextBox_TrailingIconClick(object sender, EventArgs e)
        {
            subjectNameTextBox.Enabled = !subjectNameTextBox.Enabled;
        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {

        }

        private void addExamButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteExamButton_Click(object sender, EventArgs e)
        {

        }

        private void addResourceButton_Click(object sender, EventArgs e)
        {

        }
    }
}
