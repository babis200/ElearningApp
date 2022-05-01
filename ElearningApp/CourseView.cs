using ElearningModels;

using ElearningServices;

using MaterialSkin2DotNet.Controls;

namespace ElearningApp
{
    public partial class CourseView : MaterialForm
    {
        CourseModel _course;

        CourseService _service;

        public CourseView(CourseService service ,CourseModel course )
        {
            InitializeComponent();
            _course = course;
            _service = service;

        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            /*foreach (var subject in _course.Subjects)
            {
            }*/
        }
    }
}
