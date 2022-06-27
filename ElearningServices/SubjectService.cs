
using ElearningData.Interfaces;

using ElearningModels;

namespace ElearningServices
{
    public class SubjectService
    {
        ISubjectRepo _subjectDatabase;

        public SubjectService(ISubjectRepo subjectDatabase)
        {
            _subjectDatabase = subjectDatabase;
        }

        public string Add(SubjectModel subject)
        {
            return _subjectDatabase.Add(subject);
        }

        public string Delete(SubjectModel subject)
        {
            return _subjectDatabase.Delete(subject);
        }

        public string Update(SubjectModel subject)
        {
            return _subjectDatabase.Update(subject);
        }

        public SubjectModel Get(Guid id)
        {
            return _subjectDatabase.Get(id);
        }

        public List<SubjectModel> GetAll()
        {
            return _subjectDatabase.GetAll();
        }
        
        public List<SubjectModel> GetFiltered(string subName)
        {
            return _subjectDatabase.GetFiltered(subName);
        }

        
    }
}
