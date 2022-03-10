﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElearningModels.Interfaces;

namespace ElearningModels.Models
{
    public class StudentModel : IUser
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Icon { get; set; }

        public List<CourseModel> Courses { get; set; }

        public int Grades { get; set; }

        public IUser.Role role = IUser.Role.Student;
    }
}
