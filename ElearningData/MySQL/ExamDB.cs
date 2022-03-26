using ElearningData.Interfaces;

using ElearningModels.Models;

using Microsoft.EntityFrameworkCore;

namespace ElearningData.MySQL
{
    public class ExamDB : IExamRepo
    {
        ElearningDBContext _context;

        public ExamDB(ElearningDBContext context)
        {
            _context = context;
        }

        //Η μέθοδος που προσθέτει ένα αντικείμενο στη βάση και επιστρέφει
        //ένα κενό κείμενο αν όλα πάνε καλά ή ένα κείμενο σφάλματος αν υπάρξει πρόβλημα
        public string Add(ExamModel exam)
        {
            string error = string.Empty;
            var existed = Get(exam.Id);
            if (existed != null)
            {
                return "Ο κωδικός υπάρχει ήδη στη βάση";
            }
            try
            {
                _context.Exams.Add(exam);
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
        public string Delete(ExamModel exam)
        {
            string error = string.Empty;
            try
            {
                _context.Exams.Remove(exam);
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
        public ExamModel Get(int id)
        {
            return _context.Exams
                .Include(c => c.Questions)
                .Include(c => c.Grades)
                .First(x => x.Id == id);
        }

        //Η μέθοδός που επιστρέφει μια λίστα με όλα τα αντικείμενα που υπάρχουν στη βάση
        public List<ExamModel> GetAll()
        {
            return _context.Exams
                .Include(c => c.Questions)
                .Include(c => c.Grades)
                .ToList();
        }

        //Η μέθοδος που θα ενημέρωση ένα αντικείμενο που υπάρχει στη βάση και επιστρέφει
        //ένα κενό κείμενο αν όλα πάνε καλά ή ένα κείμενο σφάλματος αν υπάρξει πρόβλημα
        public string Update(ExamModel exam)
        {
            string error = string.Empty;
            try
            {
                _context.Exams.Update(exam);
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
