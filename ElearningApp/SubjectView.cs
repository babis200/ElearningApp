
using ElearningModels.Models;

using ElearningServices;

using MaterialSkin2DotNet.Controls;

namespace ElearningApp
{
    public partial class SubjectView : MaterialForm
    {
        ServiceCollection _services;
        SubjectModel _subject;

        public SubjectView(ServiceCollection services, SubjectModel subject)
        {
            InitializeComponent();
            _services = services;
            _subject = subject;
        }

        private void SubjectView_Load(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void UpdateView()
        {
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
