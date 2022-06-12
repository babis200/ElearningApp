
using ElearningModels;

namespace ElearningData.Interfaces
{
    public interface ISubjectRepo
    {
        string Add(SubjectModel subject);

        string Delete(SubjectModel subject);

        string Update(SubjectModel subject);

        SubjectModel Get(Guid id);

        List<SubjectModel> GetAll();
    }
}
