
using ElearningModels.Models.Users;

namespace ElearningData.Interfaces
{
    internal interface IStudentRepo
    {
        string Add(StudentModel student);

        string Delete(StudentModel student);

        string Update(StudentModel student);

        StudentModel Get(int id);

        List<StudentModel> GetAll();
    }
}
