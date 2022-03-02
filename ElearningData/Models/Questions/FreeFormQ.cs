using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElearningData.Interfaces;

namespace ElearningData.Models.Questions
{
    internal class FreeFormQ : IQuestion
    {
        public string Question { get; set; }

        public string Answer { get; set; }
    }
}
