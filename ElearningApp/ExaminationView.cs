
using ElearningApp.QuestionsViews;
using ElearningModels;
using ElearningServices;
using MaterialSkin2DotNet.Controls;

namespace ElearningApp
{
    public partial class ExaminationView : MaterialForm
    {
        ExamService examService;
        ExamModel examModel;
        MaterialForm _questionForm;

        public ExaminationView(ExamService service, ExamModel exam)
        {
            InitializeComponent();
            examService = service;
            examModel = exam;
        }

        private void ExaminationView_Load(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void UpdateView()
        {
            LoadQuestion();
            _questionForm.Show();
        }

        private void LoadQuestion()
        {
            _questionForm = new TrueFalseView() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            this.panel2.Controls.Add(_questionForm);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

        }

        private void completeButton_Click(object sender, EventArgs e)
        {

        }

        private void saveAnsButton_Click(object sender, EventArgs e)
        {

        }

        private void previousButton_Click(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {

        }
    }
}
