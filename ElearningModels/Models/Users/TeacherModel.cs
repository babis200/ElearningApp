
using ElearningModels.Interfaces;


namespace ElearningModels.Models.Users
{
    public class TeacherModel : IUser
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Icon { get; set; }

        public List<CourseModel> Courses { get; set; }

        public IUser.Role role = IUser.Role.Teacher;

    }
}
