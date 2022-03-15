using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElearningModels.Models.Users;

namespace ElearningData.Interfaces
{
    internal interface ITeacherRepo
    {
        string Add(TeacherModel teacher);

        string Delete(TeacherModel teacher);

        string Update(TeacherModel teacher);

        TeacherModel Get(long id);

        List<TeacherModel> GetAll();
    }
}
