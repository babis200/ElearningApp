
using ElearningModels.Questions;

namespace ElearningData.Interfaces
{
    public interface IMatchQRepo
    {
        string Add(MatchQModel question);

        string Delete(MatchQModel question);

        string Update(MatchQModel question);

        MatchQModel Get(Guid id);

        List<MatchQModel> GetAll();
    }
}
