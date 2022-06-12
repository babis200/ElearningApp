
using ElearningData.Interfaces;

using ElearningModels.Questions;

namespace ElearningServices
{
    public class MatchQService
    {
        IMatchQRepo _matchQDatabase;

        public MatchQService(IMatchQRepo matchQDatabase)
        {
            _matchQDatabase = matchQDatabase;
        }

        public string Add(MatchQModel question)
        {
            return _matchQDatabase.Add(question);
        }

        public string Delete(MatchQModel question)
        {
            return _matchQDatabase.Delete(question);
        }

        public string Update(MatchQModel question)
        {
            return _matchQDatabase.Update(question);
        }

        public MatchQModel Get(Guid id)
        {
            return _matchQDatabase.Get(id);
        }

        public List<MatchQModel> GetAll()
        {
            return _matchQDatabase.GetAll();
        }
    }
}
