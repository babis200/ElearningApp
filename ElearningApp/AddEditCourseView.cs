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
        CourseService _service;
        CourseModel _course;

        public AddEditCourseView(CourseService service, CourseModel course)
        {
            InitializeComponent();
            _service = service;
            _course = course;

            UpdateView();
        }

        private void UpdateView()
        {
            nameTextBox.Text = _course.Name;
            foreach (var teacher in _course.Teacher)
            {
                teachersDGV.Rows.Add(teacher);
            }
            descriptionMultiLineTextBox.Text = _course.Description;
        }

        private void UpdateModel()
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            UpdateModel();
        }

        private void addSubjectButton_Click(object sender, EventArgs e)
        {

        }
    }
}
