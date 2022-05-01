using ElearningData.Interfaces;

using ElearningModels.Questions;

namespace ElearningData.MySQL
{
    public class TrueFalseQDB : ITrueFalseQRepo
    {
        ElearningDBContext _context;

        public TrueFalseQDB(ElearningDBContext context)
        {
            _context = context;
        }

        //Η μέθοδος που προσθέτει ένα αντικείμενο στη βάση και επιστρέφει
        //ένα κενό κείμενο αν όλα πάνε καλά ή ένα κείμενο σφάλματος αν υπάρξει πρόβλημα
        public string Add(TrueFalseQModel question)
        {
            string error = string.Empty;
            var existed = Get(question.Id);
            if (existed != null)
            {
                return "Ο κωδικός υπάρχει ήδη στη βάση";
            }
            try
            {
                _context.TrueFalseQs.Add(question);
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
        public string Delete(TrueFalseQModel question)
        {
            string error = string.Empty;
            try
            {
                _context.TrueFalseQs.Remove(question);
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
        public TrueFalseQModel Get(int id)
        {
            return _context.TrueFalseQs
                .First(x => x.Id == id);
        }

        //Η μέθοδός που επιστρέφει μια λίστα με όλα τα αντικείμενα που υπάρχουν στη βάση
        public List<TrueFalseQModel> GetAll()
        {
            return _context.TrueFalseQs
                .ToList();
        }

        //Η μέθοδος που θα ενημέρωση ένα αντικείμενο που υπάρχει στη βάση και επιστρέφει
        //ένα κενό κείμενο αν όλα πάνε καλά ή ένα κείμενο σφάλματος αν υπάρξει πρόβλημα
        public string Update(TrueFalseQModel question)
        {
            string error = string.Empty;
            try
            {
                _context.TrueFalseQs.Update(question);
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

