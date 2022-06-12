
using ElearningModels;

namespace ElearningData.Interfaces
{
    public interface ICourseRepo
    {
        string Add(CourseModel course);

        string Delete(CourseModel course);

        string Update(CourseModel course);

        CourseModel Get(Guid id);

        List<CourseModel> GetAll();
    }
}
