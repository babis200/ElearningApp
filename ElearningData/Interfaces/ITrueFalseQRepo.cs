
using ElearningModels.Questions;

namespace ElearningData.Interfaces
{
    public interface ITrueFalseQRepo
    {
        string Add(TrueFalseQModel question);

        string Delete(TrueFalseQModel question);

        string Update(TrueFalseQModel question);

        TrueFalseQModel Get(Guid id);

        List<TrueFalseQModel> GetAll();
    }
}
