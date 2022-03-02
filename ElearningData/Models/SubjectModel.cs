using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElearningData.Models
{
    internal class SubjectModel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public List<string> Resources { get; set; }

        public List<ExamModel> Exams { get; set; }
    }
}
