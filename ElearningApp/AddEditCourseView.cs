using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ElearningModels.Models;

using ElearningServices;

using MaterialSkin2DotNet.Controls;

namespace ElearningApp
{
    public partial class AddEditCourseView: MaterialForm
    {
        ServiceCollection _services;
        CourseModel _course;

        public AddEditCourseView(ServiceCollection services, CourseModel course)
        {
            InitializeComponent();
            _services = services;
            _course = course;

            UpdateView();
        }

        private void UpdateView()
        {
            nameTextBox.Text = _course.Name;
            foreach (var teacher in _course.Teachers)
            {
                teachersDGV.Rows.Add(teacher);
            }
            descriptionMultiLineTextBox.Text = _course.Description;
        }

        private void UpdateModel()
        {
            _course.Name = nameTextBox.Text;
            foreach (DataGridViewRow row in teachersDGV.Rows)
            {
                _course.Teachers.Add(row.Cells[0].ToString());
            }
            _course.Description = descriptionMultiLineTextBox.Text;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //TODO - validate
            UpdateModel();
            
        }

        private void addSubjectButton_Click(object sender, EventArgs e)
        {
            if (!ViewTools.IsFormOpened<SubjectView>())
            {
                var subjectView = new SubjectView(_services, new SubjectModel());
                subjectView.Show();
            }
            else
            {
                ViewTools.GetOpenedForm<SubjectView>().Focus();
            }
        }
    }
}
