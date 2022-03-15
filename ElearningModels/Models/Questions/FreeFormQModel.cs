using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElearningModels.Interfaces;

namespace ElearningModels.Models.Questions
{
    public class FreeFormQModel : IQuestion
    {
        public int Id { get; set; }

        public string Question { get; set; }

        public string Answer { get; set; }
        
    }
}
