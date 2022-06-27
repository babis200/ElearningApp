using ElearningModels;

using ElearningServices;

using MaterialSkin2DotNet.Controls;

using System.Windows.Forms;

using static ElearningApp.AppEnums;

namespace ElearningApp
{
    public partial class MainMenu : MaterialForm
    {
        ServiceCollection _services;

        List<CourseModel> _courses;

        CourseModel _selectedCourse;

        public MainMenu(ServiceCollection services)
        {
            InitializeComponent();
            courseDGV.AutoGenerateColumns = false;
            _services = services;
            _courses = _services.CourseService.GetAll();

            UpdateView();
        }


        private void UpdateView()
        {
            courseDGV.DataSource = null;
            courseDGV.DataSource = _services.CourseService.GetAll();
        }
       
        private void newCourseButton_Click(object sender, EventArgs e)
        {
            if (!ViewTools.IsFormOpened<AddEditCourseView>())
            {
                var courseView = new AddEditCourseView(Work.Add, _services, new CourseModel(), UpdateView);
                courseView.ShowDialog();
            }
            else
            {
                ViewTools.GetOpenedForm<AddEditCourseView>().Focus();
            }
        }

        private void courseDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedCourse = GetSelectedCourse();
            if (_selectedCourse == null)
            {
                MessageBox.Show("Παρακαλώ επιλέξτε ένα μάθημα", "Δεν υπάρχει επιλεγμέμη γραμμή", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ViewTools.IsFormOpened<CourseView>())
            {
                var subjectView = new CourseView(_services, _selectedCourse);
                subjectView.ShowDialog();
            }
            else
            {
                ViewTools.GetOpenedForm<CourseView>().Focus();
            }
        }

        CourseModel GetSelectedCourse()
        {
            Guid id = Guid.Empty;
            if (courseDGV.CurrentRow != null)
            {
                id = (Guid)courseDGV.CurrentRow.Cells[0].Value;
            }

            return _courses.FirstOrDefault(x => x.Id == id);
        }

        private void addCourseButton_Click(object sender, EventArgs e)
            => AddEditCourse(Work.Add);



        private void editCourseButton_Click(object sender, EventArgs e)
            => AddEditCourse(Work.Edit);

        private void deleteCourseButton_Click(object sender, EventArgs e)
        {
            //βρες τoν επιλεγμένo μαθημα
            _selectedCourse = GetSelectedCourse();
            //Αν δεν έχει επιλεγεί κάποιο μάθημα
            if (_selectedCourse == null)
            {
                MessageBox.Show("Παρακαλώ επιλέξτε ένα μάθημα.", "Δεν υπάρχει επιλεγμέμη γραμμή", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Επιβεβαίωση διαγραφής
            var value = MessageBox.Show("Είστε σίγουροι ότι θέλετε να διαγράψετε το επιλεγμένο μάθημα;", "Διαγραφή μαθήματος", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (value == DialogResult.No) return;

            //Διέγραψε τον επιλεγμενο ΦΠΑ            
            _services.CourseService.Delete(_selectedCourse);
            UpdateView();
            MessageBox.Show("Το μάθημα διαγράφηκε επιτυχώς.", "Επιτυχής διαγραφή", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void previewCourseButton_Click(object sender, EventArgs e)
        {
            var course = GetSelectedCourse();
            if (course == null)
            {
                MessageBox.Show("Παρακαλώ επιλέξτε ένα μάθημα", "Δεν υπάρχει επιλεγμέμη γραμμή", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var addView = new CourseView(_services, course);
            addView.ShowDialog(this);
            addView.Dispose();
        }            

        private void AddEditCourse(Work workType)
        {
            var course = workType == Work.Add ? new CourseModel() : GetSelectedCourse();
            if (course == null)
            {
                MessageBox.Show("Παρακαλώ επιλέξτε ένα μάθημα", "Δεν υπάρχει επιλεγμέμη γραμμή", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var addView = new AddEditCourseView(workType, _services, course, UpdateView);
            addView.ShowDialog(this);
            addView.Dispose();
        }
    }
}