using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElearningModels.Models.Questions;

namespace ElearningData.Interfaces
{
    public interface IFreeFormQRepo
    {
        string Add(FreeFormQModel question);

        string Delete(FreeFormQModel question);

        string Update(FreeFormQModel question);

        FreeFormQModel Get(long id);

        List<FreeFormQModel> GetAll();
    }
}
