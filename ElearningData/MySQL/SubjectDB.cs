using ElearningData.Interfaces;

using ElearningModels;

using Microsoft.EntityFrameworkCore;

namespace ElearningData.MySQL
{
    public class SubjectDB : ISubjectRepo
    {
        ElearningDBContext _context;

        public SubjectDB(ElearningDBContext context)
        {
            _context = context;
        }

        //Η μέθοδος που προσθέτει ένα αντικείμενο στη βάση και επιστρέφει
        //ένα κενό κείμενο αν όλα πάνε καλά ή ένα κείμενο σφάλματος αν υπάρξει πρόβλημα
        public string Add(SubjectModel subject)
        {
            string error = string.Empty;
            var existed = Get(subject.Id);
            if (existed != null)
            {
                return "Ο κωδικός υπάρχει ήδη στη βάση";
            }
            try
            {
                _context.Subjects.Add(subject);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                error = e.Message;
            }

            return error;
        }

        //Η μέθοδος που διαγράφει ένα αντικείμενο από τη βάση  και επιστρέφει
        //ένα κενό κείμενο αν όλα πάνε καλά ή ένα κείμενο σφάλματος αν υπάρξει πρόβλημα
        public string Delete(SubjectModel subject)
        {
            string error = string.Empty;
            try
            {
                _context.Subjects.Remove(subject);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                error = e.Message;
            }

            return error;
        }

        //Η μέθοδος που κάνει κλήση στη βάση και επιστρέφει το αντικείμενο 
        //με βάση το id του. Αν δεν βρει κάτι επιστρέφει null
        public SubjectModel Get(int id)
        {
            return _context.Subjects
                .Include(c => c.Exams)
                .First(x => x.Id == id);
        }

        //Η μέθοδός που επιστρέφει μια λίστα με όλα τα αντικείμενα που υπάρχουν στη βάση
        public List<SubjectModel> GetAll()
        {
            return _context.Subjects
                .Include(c => c.Exams)
                .ToList();
        }

        //Η μέθοδος που θα ενημέρωση ένα αντικείμενο που υπάρχει στη βάση και επιστρέφει
        //ένα κενό κείμενο αν όλα πάνε καλά ή ένα κείμενο σφάλματος αν υπάρξει πρόβλημα
        public string Update(SubjectModel subject)
        {
            string error = string.Empty;
            try
            {
                _context.Subjects.Update(subject);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                error = e.Message;
            }

            return error;
        }
    }
}
