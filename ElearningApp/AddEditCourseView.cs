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

using MaterialSkin2DotNet;
using MaterialSkin2DotNet.Controls;

using static ElearningApp.AppEnums;

namespace ElearningApp
{
    public partial class AddEditCourseView: MaterialForm
    {
        ServiceCollection _services;
        CourseModel _course;
        readonly Work _work;
        readonly Action _updateParent;

        public AddEditCourseView(Work work, ServiceCollection services, CourseModel course, Action updateParent)
        {
            InitializeComponent();
            _services = services;
            _course = course;
            _updateParent = updateParent;
            _work = work;

            switch(_work)
            {
                case Work.Add:
                    this.Text = "Δημιουργία Μαθήματος";
                    break;
                case Work.Edit:
                    this.Text = "Επεξεργασία Μαθήματος";
                    break;
                case Work.Preview:
                    this.Text = "Προβολή μαθήματος";
                    ViewTools.ReadOnlyAll(this);
                    break;
            }

            UpdateView();
        }

        private void UpdateView()
        {
            //Name
            nameTextBox.Text = _course.Name;
            //Teachers
            teachersDGV.DataSource = null;
            teachersDGV.DataSource = _course.Teachers;
            //Description
            descriptionMultiLineTextBox.Text = _course.Description;
            //Subjects
            UpdateSuvbectsListBox();
        }
        private void UpdateSuvbectsListBox()
        {
            if (_course.Subjects is null) return;
            foreach (var subject in _course.Subjects)
            {
                MaterialListBoxItem lb = new MaterialListBoxItem();
                lb.Text = subject.Name;
                lb.SecondaryText = subject.Description;
                //Φυλάω στο Tag το Id για να ειναι πιο ευκολη η ευρεση του subject sto UpdateModel
                lb.Tag = subject.Id;
                subjectsListBox.Items.Add(lb);
            }
        }

        private void UpdateModel()
        {
            //Name
            _course.Name = nameTextBox.Text;
            //Teachers
            GetTeachersFromDGV();
            //Description
            _course.Description = descriptionMultiLineTextBox.Text;
            //Subjects
            GetSubjectsFromListBox();
        }

        private void GetTeachersFromDGV()
        {
            _course.Teachers = new List<string>();
            foreach (DataGridViewRow row in teachersDGV.Rows)
            {
                _course.Teachers.Add(row.Cells["TeacherName"].FormattedValue.ToString()); 
            }
        }

        private void GetSubjectsFromListBox()
        {
            //Empty the list of subjects
            _course.Subjects = new List<SubjectModel>();
            //Fill it with subjects from the ListBox
            foreach (var item in subjectsListBox.Items)
            {
                //Γνωρίζω ότι στο Tag αποθηκεύω το Id toy Subject
                _course.Subjects.Add(_services.SubjectService.Get((Guid)item.Tag));
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //TODO - validate course
            UpdateModel();

            try
            {
                switch (_work)
                {
                    case Work.Add:
                        _services.CourseService.Add(_course);
                        break;
                    case Work.Edit:
                        _services.CourseService.Update(_course);
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
        }

        private void addSubjectButton_Click(object sender, EventArgs e)
        {
            if (!ViewTools.IsFormOpened<SubjectView>())
            {
                var subjectView = new SubjectView(_services, UpdateView);
                subjectView.Show();
            }
            else
            {
                ViewTools.GetOpenedForm<SubjectView>().Focus();
            }
        }
    }
}
