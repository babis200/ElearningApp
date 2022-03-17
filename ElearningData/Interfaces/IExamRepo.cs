
using ElearningModels.Models;

namespace ElearningData.Interfaces
{
    internal interface IExamRepo
    {
        string Add(ExamModel exam);

        string Delete(ExamModel exam);

        string Update(ExamModel exam);

        ExamModel Get(int id);

        List<ExamModel> GetAll();
    }
}
