using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElearningModels.Models.Questions;

namespace ElearningData.Interfaces
{
    internal interface IMatchQRepo
    {
        string Add(MatchQModel question);

        string Delete(MatchQModel question);

        string Update(MatchQModel question);

        MatchQModel Get(long id);

        List<MatchQModel> GetAll();
    }
}
