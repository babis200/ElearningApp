
using ElearningData.Interfaces;

using ElearningModels.Models.Questions;

namespace ElearningServices
{
    public class FreeFormQService
    {
        IFreeFormQRepo _freeFormQDatabase;

        public FreeFormQService(IFreeFormQRepo freeFormQDatabase)
        {
            _freeFormQDatabase = freeFormQDatabase;
        }

        public string Add(FreeFormQModel question)
        {
            return _freeFormQDatabase.Add(question);
        }

        public string Delete(FreeFormQModel question)
        {
            return _freeFormQDatabase.Delete(question);
        }

        public string Update(FreeFormQModel question)
        {
            return _freeFormQDatabase.Update(question);
        }

        public FreeFormQModel Get(int id)
        {
            return _freeFormQDatabase.Get(id);
        }

        public List<FreeFormQModel> GetAll()
        {
            return _freeFormQDatabase.GetAll();
        }
    }
}
