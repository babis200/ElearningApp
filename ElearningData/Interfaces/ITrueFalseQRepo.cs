
using ElearningModels.Models.Questions;

namespace ElearningData.Interfaces
{
    public interface ITrueFalseQRepo
    {
        string Add(TrueFalseQModel question);

        string Delete(TrueFalseQModel question);

        string Update(TrueFalseQModel question);

        TrueFalseQModel Get(int id);

        List<TrueFalseQModel> GetAll();
    }
}
