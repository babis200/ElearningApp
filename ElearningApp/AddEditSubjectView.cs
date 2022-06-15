using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ElearningModels;

using ElearningServices;

using MaterialSkin2DotNet.Controls;

using static ElearningApp.AppEnums;

namespace ElearningApp
{
    public partial class AddEditSubjectView : MaterialForm
    {
        Work _workType;
        SubjectModel _subject;
        ServiceCollection _services;
        Action _updateParent;

        public AddEditSubjectView(Work workType, SubjectModel subject, ServiceCollection services, Action updateParent)
        {
            InitializeComponent();
            resourcesDGV.AutoGenerateColumns = false;
            examsDGV.AutoGenerateColumns = false;
            

            _workType = workType;
            _subject = subject;
            _services = services;
            _updateParent = updateParent;
        }

        private void AddEditSubjectView_Load(object sender, EventArgs e)
        {
            switch(_workType)
            {
                case Work.Add:
                    this.Text = "Προσθήκη κεφαλαίου";
                    break;
                case Work.Edit:
                    this.Text = "Επεξεργασία κεφαλαίου";
                    break;
                case Work.Preview:
                    this.Text = "Προβολή κεφαλαίου";
                    ViewTools.ReadOnlyAll(this);
                    break;
            }

            UpdateView();
        }

        private void UpdateView()
        {
            nameTextBox.Text = _subject.Name;
            descriptionTextBox.Text = _subject.Description;

            if(_subject.Resources is null) _subject.Resources = new List<string>();
            foreach (var resource in _subject.Resources)
            {
                resourcesDGV.Rows.Add(resource);
            }
            
            examsDGV.DataSource = null;
            examsDGV.DataSource = _subject.Exams;

        }

        private void UpdateModel()
        {
            _subject.Name = nameTextBox.Text;
            _subject.Description = descriptionTextBox.Text;

            foreach (DataGridViewRow row in resourcesDGV.Rows)
                _subject.Resources.Add(row.Cells[0].Value.ToString());

            foreach (DataGridViewRow row in examsDGV.Rows)
                _subject.Exams.Add(_services.ExamService.Get((Guid)row.Cells["Id"].Value));
        }

        private void addResourcesButton_Click(object sender, EventArgs e)
        {
            resourceFileDialog.ShowDialog();

            if (_subject.Resources is null)_subject.Resources = new List<string>();            
            _subject.Resources.Add(resourceFileDialog.FileName);
            UpdateView();
        }

        private void addExamButton_Click(object sender, EventArgs e)
        {
            if (!ViewTools.IsFormOpened<ExamView>())
            {
                var subjectView = new AddEditExamView(Work.Add, new ExamModel(), _services.ExamService, UpdateView);
                subjectView.Show();
            }
            else
            {
                ViewTools.GetOpenedForm<SubjectView>().Focus();
            }
        }

        private void resourcesDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            resourceFileDialog.ShowDialog();

            if (_subject.Resources is null) _subject.Resources = new List<string>();
            _subject.Resources.Add(resourceFileDialog.FileName);
            UpdateView();
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
                        _services.SubjectService.Add(_subject);
                        break;
                    case Work.Edit:
                        _services.SubjectService.Update(_subject);
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

        private void examsDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void resourcesDGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Delete) && !resourcesDGV.CurrentCell.IsInEditMode)
            {
                if (resourcesDGV.CurrentRow != null)
                    _subject.Resources.Remove(resourcesDGV.CurrentRow.Cells[0].Value.ToString());
            }
        }
    }
}
