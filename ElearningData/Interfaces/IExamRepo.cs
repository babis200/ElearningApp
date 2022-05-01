
using ElearningModels;

namespace ElearningData.Interfaces
{
    public interface IExamRepo
    {
        string Add(ExamModel exam);

        string Delete(ExamModel exam);

        string Update(ExamModel exam);

        ExamModel Get(int id);

        List<ExamModel> GetAll();
    }
}
