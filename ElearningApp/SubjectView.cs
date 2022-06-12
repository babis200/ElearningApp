
using ElearningData.MySQL;

using ElearningModels;

using ElearningServices;

using MaterialSkin2DotNet.Controls;

using System.Windows.Forms;

using static ElearningApp.AppEnums;

namespace ElearningApp
{
    public partial class SubjectView : MaterialForm
    {
        ServiceCollection _services;
        List<SubjectModel> _subjects;
        Action _updateParent;

        public SubjectView(ServiceCollection services, Action updateParent)
        {
            InitializeComponent();
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
            UpdateView();
        }

        private void deleteSubjectButton_Click(object sender, EventArgs e)
        {

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
    }
}
