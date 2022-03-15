using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElearningModels.Models.Questions;

namespace ElearningData.Interfaces
{
    internal interface IMultipleChoiceQRepo
    {
        string Add(MultipleChoiceQModel question);

        string Delete(MultipleChoiceQModel question);

        string Update(MultipleChoiceQModel question);

        MultipleChoiceQModel Get(long id);

        List<MultipleChoiceQModel> GetAll();
    }
}
