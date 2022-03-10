using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElearningModels.Interfaces;

namespace ElearningModels.Models.Users
{
    public class TeacherModel : IUser
    {
        public int Id { get; set; }
       
        public string Name { get; set; }

        public List<CourseModel> Courses { get; set; }


        public IUser.Role role = IUser.Role.Teacher;

    }
}
