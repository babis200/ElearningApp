
using ElearningModels.Questions;

namespace ElearningData.Interfaces
{
    internal interface IMultipleChoiceQRepo
    {
        string Add(MultipleChoiceQModel question);

        string Delete(MultipleChoiceQModel question);

        string Update(MultipleChoiceQModel question);

        MultipleChoiceQModel Get(Guid id);

        List<MultipleChoiceQModel> GetAll();
    }
}
