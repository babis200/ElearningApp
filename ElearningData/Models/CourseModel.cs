using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElearningModels.Models
{
    public class CourseModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Teacher { get; set; }

        public List<SubjectModel> Subjects{ get; set; }

    }
}
