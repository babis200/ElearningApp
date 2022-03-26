
using ElearningData.Interfaces;

using ElearningModels.Models;

namespace ElearningServices
{
    public class ExamService
    {
        IExamRepo _examDatabase;

        public ExamService(IExamRepo examDatabase)
        {
            _examDatabase = examDatabase;
        }

        public string Add(ExamModel exam)
        {
            return _examDatabase.Add(exam);
        }

        public string Delete(ExamModel exam)
        {
            return _examDatabase.Delete(exam);
        }

        public string Update(ExamModel exam)
        {
            return _examDatabase.Update(exam);
        }

        public ExamModel Get(int id)
        {
            return _examDatabase.Get(id);
        }

        public List<ExamModel> GetAll()
        {
            return _examDatabase.GetAll();
        }
    }
}
