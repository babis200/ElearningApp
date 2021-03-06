
using ElearningModels;

using ElearningServices;

using MaterialSkin2DotNet.Controls;

using static ElearningApp.AppEnums;

namespace ElearningApp
{
    public partial class SubjectView : MaterialForm
    {
        ServiceCollection _services;
        List<SubjectModel> _subjects;
        Action _updateParent;
        public SubjectModel _selectedSubject;

        public SubjectView(ServiceCollection services, Action updateParent)
        {
            InitializeComponent();
            subjectsDGV.AutoGenerateColumns = false;
            _services = services;
            _updateParent = updateParent;
        }

        private void SubjectView_Load(object sender, EventArgs e)
        {
            _subjects = _services.SubjectService.GetAll();
            UpdateView();
        }

        private void UpdateView()
        {
            subjectsDGV.DataSource = null;
            subjectsDGV.DataSource = _subjects;
        }


        private void subjectNameTextBox_TrailingIconClick(object sender, EventArgs e)
        {
            subjectNameTextBox.Enabled = !subjectNameTextBox.Enabled;
        }
                
        private void selectButton_Click(object sender, EventArgs e)
        {
            _selectedSubject = GetSelectedSubject();
            if (_selectedSubject == null)
            {
                MessageBox.Show("Παρακαλώ επιλέξτε ένα μάθημα", "Δεν υπάρχει επιλεγμέμη γραμμή", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Close();
        }

        private void addSubjectButton_Click(object sender, EventArgs e) => AddEditSubject(Work.Add);
        
        private void AddEditSubject(Work workType)
        {
            var subject = workType == Work.Add ? new SubjectModel() : GetSelectedSubject();
            if (subject == null)
            {
                MessageBox.Show("Παρακαλώ επιλέξτε ένα κεφάλαιο", "Δεν υπάρχει επιλεγμέμη γραμμή", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var addView = new AddEditSubjectView(workType, subject, _services, UpdateView);
            addView.ShowDialog(this);
            addView.Dispose();
        }

        private void deleteSubjectButton_Click(object sender, EventArgs e)
        {
            //βρες τoν επιλεγμένo μαθημα
            _selectedSubject = GetSelectedSubject();
            //Αν δεν έχει επιλεγεί κάποιο μάθημα
            if (_selectedSubject == null)
            {
                MessageBox.Show("Παρακαλώ επιλέξτε ένα κεφάλαιο.", "Δεν υπάρχει επιλεγμέμη γραμμή", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Επιβεβαίωση διαγραφής
            var value = MessageBox.Show("Είστε σίγουροι ότι θέλετε να διαγράψετε το επιλεγμένο κεφάλαιο;", "Διαγραφή κεφαλαίου", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (value == DialogResult.No) return;

            //Διέγραψε τον επιλεγμενο ΦΠΑ            
            _services.SubjectService.Delete(_selectedSubject);
            _subjects = _services.SubjectService.GetAll();
            UpdateView();
            MessageBox.Show("Το κεφάλαιο διαγράφηκε επιτυχώς.", "Επιτυχής διαγραφή", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void editSubjectButton_Click(object sender, EventArgs e) => AddEditSubject(Work.Edit);

        SubjectModel GetSelectedSubject()
        {
            Guid id = Guid.Empty;
            if (subjectsDGV.CurrentRow != null)
            {
                id = Guid.Parse(subjectsDGV.CurrentRow.Cells[0].Value.ToString());
            }

            return _subjects.FirstOrDefault(x => x.Id == id);
        }

        private void subjectNameTextBox_TrailingIconClick_1(object sender, EventArgs e)
        {
            _subjects = string.IsNullOrWhiteSpace(subjectNameTextBox.Text) ?
            _services.SubjectService.GetAll() :
            _services.SubjectService.GetFiltered(subjectNameTextBox.Text);
            UpdateView();
        }
    }
}
