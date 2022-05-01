using ElearningData.Interfaces;

using ElearningModels;

namespace ElearningServices
{
    public class CourseService
    {

        ICourseRepo _courseDatabase;

        public CourseService(ICourseRepo courseDatabase)
        {
            _courseDatabase = courseDatabase;
        }

        public string Add(CourseModel course)
        {
            return _courseDatabase.Add(course);
        }

        public string Delete(CourseModel course)
        {
            return _courseDatabase.Delete(course);
        }

        public string Update(CourseModel course)
        {
            return _courseDatabase.Update(course);
        }

        public CourseModel Get(int id)
        {
            return _courseDatabase.Get(id);
        }

        public List<CourseModel> GetAll()
        {
            return _courseDatabase.GetAll();
        }

    }
}
