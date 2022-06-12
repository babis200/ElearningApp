
using ElearningModels.Questions;

namespace ElearningData.Interfaces
{
    public interface IFreeFormQRepo
    {
        string Add(FreeFormQModel question);

        string Delete(FreeFormQModel question);

        string Update(FreeFormQModel question);

        FreeFormQModel Get(Guid id);

        List<FreeFormQModel> GetAll();
    }
}
