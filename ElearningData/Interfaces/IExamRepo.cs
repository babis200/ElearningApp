using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElearningModels.Models;

namespace ElearningData.Interfaces
{
    internal interface IExamRepo
    {
        string Add(ExamModel exam);

        string Delete(ExamModel exam);

        string Update(ExamModel exam);

        ExamModel Get(long id);

        List<ExamModel> GetAll();
    }
}
