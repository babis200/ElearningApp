
using ElearningData.Interfaces;

using ElearningModels.Questions;

namespace ElearningServices
{
    public class TrueFalseQService
    {
        ITrueFalseQRepo _trueFalseDatabase;

        public TrueFalseQService(ITrueFalseQRepo trueFalseDatabase)
        {
            _trueFalseDatabase = trueFalseDatabase;
        }

        public string Add(TrueFalseQModel question)
        {
            return _trueFalseDatabase.Add(question);
        }

        public string Delete(TrueFalseQModel question)
        {
            return _trueFalseDatabase.Delete(question);
        }

        public string Update(TrueFalseQModel question)
        {
            return _trueFalseDatabase.Update(question);
        }

        public TrueFalseQModel Get(int id)
        {
            return _trueFalseDatabase.Get(id);
        }

        public List<TrueFalseQModel> GetAll()
        {
            return _trueFalseDatabase.GetAll();
        }
    }
}
