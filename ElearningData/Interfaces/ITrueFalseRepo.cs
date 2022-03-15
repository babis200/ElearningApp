using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElearningModels.Models.Questions;

namespace ElearningData.Interfaces
{
    internal interface ITrueFalseRepo
    {
        string Add(TrueFalseQModel question);

        string Delete(TrueFalseQModel question);

        string Update(TrueFalseQModel question);

        TrueFalseQModel Get(long id);

        List<TrueFalseQModel> GetAll();
    }
}
