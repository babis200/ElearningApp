using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElearningModels.Interfaces;

namespace ElearningModels.Models.Questions
{
    public class TrueFalseQModel : IQuestion
    {
        public string Question { get; set; }

        public bool Answer { get; set; }
    }
}
