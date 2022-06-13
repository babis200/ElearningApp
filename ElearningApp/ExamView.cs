using ElearningModels;
using ElearningServices;
using MaterialSkin2DotNet.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ElearningApp.AppEnums;

namespace ElearningApp
{
    public partial class ExamView : MaterialForm
    {
        ExamService _service;

        List<ExamModel> _exams;

        bool _select;

        public ExamModel _selectedExam;

        public ExamView(ExamService service, bool select = false, List<ExamModel> exams = null)
        {
            InitializeComponent();

            _service = service;
            _select = select;
            _exams = exams;
            selectPanel.Visible = select;
        }

        private void ExamView_Load(object sender, EventArgs e)
        {
            ReloadView();
        }

        public void ReloadView()
        {
            _exams = _service.GetAll();
            UpdateView();
        }

        public void UpdateView()
        {
            examsDGV.DataSource = null;
            examsDGV.DataSource = _exams;
        }

        private void subjectNameTextBox_TrailingIconClick(object sender, EventArgs e)
        {

        }

        private void addExamButton_Click(object sender, EventArgs e) => AddEditExam(Work.Add);

        private void deleteExamButton_Click(object sender, EventArgs e)
        {
            //βρες τoν επιλεγμένo διαγώνισμα
            _selectedExam =  GetSelectedExam();
            //Αν δεν έχει επιλεγεί κάποιο διαγώνισμα
            if (_selectedExam == null)
            {
                MessageBox.Show("Παρακαλώ επιλέξτε ένα διαγώνισμα.", "Δεν υπάρχει επιλεγμέμη γραμμή", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Επιβεβαίωση διαγραφής
            var value = MessageBox.Show("Είστε σίγουροι ότι θέλετε να διαγράψετε το επιλεγμένο διαγώνισμα;", "Διαγραφή διαγωνίσματος", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (value == DialogResult.No) return;

            //Διέγραψε το επιλεγμενο διαγώνισμα            
            _service.Delete(_selectedExam);
            ReloadView();
            MessageBox.Show("Το διαγώνισμα διαγράφηκε επιτυχώς.", "Επιτυχής διαγραφή", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void editExamButton_Click(object sender, EventArgs e) => AddEditExam(Work.Add);

        void AddEditExam(Work work)
        {
            var exam = work == Work.Add ? new ExamModel() : GetSelectedExam();
            if (exam == null)
            {
                MessageBox.Show("Παρακαλώ επιλέξτε ένα διαγώνισμα", "Δεν υπάρχει επιλεγμέμη γραμμή", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ViewTools.IsFormOpened<AddEditExamView>())
            {
                var examView = new AddEditExamView(work, exam, _service, ReloadView);
                examView.ShowDialog(this);
            }
            else
            {
                ViewTools.GetOpenedForm<AddEditExamView>().Focus();
            }

        }

        private void selectButton_Click(object sender, EventArgs e)
        {

        }

        ExamModel GetSelectedExam()
        {
            if (_exams != null)
            {
                Guid id = Guid.Empty;
                if (examsDGV.CurrentRow != null)
                {
                    id = Guid.Parse(examsDGV.CurrentRow.Cells[0].Value.ToString()); 
                }
                return _exams.FirstOrDefault(x => x.Id == id);
            }
            return null;
        }


    }
}
