using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElearningModels.Interfaces;

namespace ElearningModels.Models.Questions
{
    public class MultipleChoiceQ : IQuestion
    {
        public string Question { get; set; }

        public List<string> Choices { get; set; }
    }
}
