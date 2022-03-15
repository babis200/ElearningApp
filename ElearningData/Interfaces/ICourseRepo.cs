using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElearningModels.Models;

namespace ElearningData.Interfaces
{
    public interface ICourseRepo
    {
        string Add(CourseModel course);

        string Delete(CourseModel course);

        string Update(CourseModel course);

        CourseModel Get(long id);

        List<CourseModel> GetAll();
    }
}
