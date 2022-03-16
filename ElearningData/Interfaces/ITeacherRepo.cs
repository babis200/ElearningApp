
using ElearningModels.Models.Users;

namespace ElearningData.Interfaces
{
    internal interface ITeacherRepo
    {
        string Add(TeacherModel teacher);

        string Delete(TeacherModel teacher);

        string Update(TeacherModel teacher);

        TeacherModel Get(int id);

        List<TeacherModel> GetAll();
    }
}
