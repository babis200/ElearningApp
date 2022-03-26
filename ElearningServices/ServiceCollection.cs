using ElearningData;
using ElearningData.MySQL;

namespace ElearningServices
{
    public class ServiceCollection
    {
        public CourseService CourseService { get; set; }

        public ExamService ExamService { get; set; }

        public FreeFormQService FreeFormQService { get; set; }

        public MatchQService MatchQService { get; set; }

        public SubjectService SubjectService { get; set; }

        public TrueFalseQService TrueFalseQService { get; set; }


        public ServiceCollection(ElearningDBContext _context)
        {
            CourseService = new CourseService(new CourseDB(_context));

            ExamService = new ExamService(new ExamDB(_context));

            FreeFormQService = new FreeFormQService(new FreeFormQDB(_context));

            SubjectService = new SubjectService(new SubjectDB(_context));

            MatchQService = new MatchQService(new MatchQDB(_context));

            TrueFalseQService = new TrueFalseQService(new TrueFalseQDB(_context));

        }
    }
}
