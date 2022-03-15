using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElearningModels.Models;

namespace ElearningData.Interfaces
{
    internal interface ISubjectRepo
    {
        string Add(SubjectModel subject);

        string Delete(SubjectModel subject);

        string Update(SubjectModel subject);

        SubjectModel Get(long id);

        List<SubjectModel> GetAll();
    }
}
