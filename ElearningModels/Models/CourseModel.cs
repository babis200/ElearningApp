namespace ElearningModels.Models
{
    public class CourseModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Teacher { get; set; }

        public List<SubjectModel> Subjects { get; set; }

        public List<ExamModel> Exams { get; set; }

    }
}
