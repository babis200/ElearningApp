
using ElearningModels.Models;

namespace ElearningData.Interfaces
{
    public interface ICourseRepo
    {
        string Add(CourseModel course);

        string Delete(CourseModel course);

        string Update(CourseModel course);

        CourseModel Get(int id);

        List<CourseModel> GetAll();
    }
}
