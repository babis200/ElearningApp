
using ElearningModels.Models;

namespace ElearningData.Interfaces
{
    internal interface ISubjectRepo
    {
        string Add(SubjectModel subject);

        string Delete(SubjectModel subject);

        string Update(SubjectModel subject);

        SubjectModel Get(int id);

        List<SubjectModel> GetAll();
    }
}
