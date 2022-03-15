using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElearningModels.Models.Users;

namespace ElearningData.Interfaces
{
    internal interface IStudentRepo
    {
        string Add(StudentModel student);

        string Delete(StudentModel student);

        string Update(StudentModel student);

        StudentModel Get(long id);

        List<StudentModel> GetAll();
    }
}
