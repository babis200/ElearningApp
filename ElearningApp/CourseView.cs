
using ElearningModels.Models;

using MaterialSkin2DotNet.Controls;

namespace ElearningApp
{
    public partial class CourseView : MaterialForm
    {
        CourseModel _course;

        public CourseView(CourseModel course)
        {
            InitializeComponent();
            _course = course;

        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            /*foreach (var subject in _course.Subjects)
            {
            }*/
        }
    }
}
