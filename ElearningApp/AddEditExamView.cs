
using ElearningModels;
using ElearningServices;
using MaterialSkin2DotNet.Controls;
using static ElearningApp.AppEnums;

namespace ElearningApp
{
    public partial class AddEditExamView : MaterialForm
    {
        Work _workType;
        ExamModel _exam;
        ExamService _service;
        Action _updateParent;

        public AddEditExamView(Work workType, ExamModel exam, ExamService service, Action updateParent)
        {
            InitializeComponent();
            _workType = workType;
            _exam = exam;
            _service = service;
            _updateParent = updateParent;
        }

        private void AddEditExamViewLoad(object sender, EventArgs e)
        {
            switch (_workType)
            {
                case Work.Add:
                    this.Text = "Προσθήκη διαγωνίσματος";
                    break;
                case Work.Edit:
                    this.Text = "Επεξεργασία διαγωνίσματος";
                    break;
                case Work.Preview:
                    this.Text = "Προβολή διαγωνίσματος";
                    ViewTools.ReadOnlyAll(this);
                    break;
            }

            UpdateView();
        }

        private void UpdateView()
        {
            nameTextBox.Text = _exam.Name;
            descriptionTextBox.Text = _exam.Description;
            minGradeTextBox.Text = _exam.MinGrade.ToString();
            maxGradeTextBox.Text = _exam.MaxGrade.ToString();            
        }

        private void UpdateModel()
        {
            _exam.Name = nameTextBox.Text;
            _exam.Description = descriptionTextBox.Text;

            _exam.MinGrade = int.Parse(minGradeTextBox.Text);
            _exam.MaxGrade = int.Parse(maxGradeTextBox.Text);
        }

        
        private void saveButton_Click(object sender, EventArgs e)
        {
            UpdateModel();
            //Validation
            try
            {
                switch (_workType)
                {
                    case Work.Add:
                        _service.Add(_exam);
                        break;
                    case Work.Edit:
                        _service.Update(_exam);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Πρόβλημα ενημέρωσης", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Η βάση ενημερώθηκε επιτυχώς.", "Ενημέρωση βάσης", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Invoke(_updateParent);
            this.Close();
        }

    }
}
