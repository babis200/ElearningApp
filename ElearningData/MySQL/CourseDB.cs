using ElearningData.Interfaces;

using ElearningModels;

using Microsoft.EntityFrameworkCore;

namespace ElearningData.MySQL
{
    public class CourseDB : ICourseRepo
    {
        ElearningDBContext _context;

        public CourseDB(ElearningDBContext context)
        {
            _context = context;
        }

        //Η μέθοδος που προσθέτει ένα αντικείμενο στη βάση και επιστρέφει
        //ένα κενό κείμενο αν όλα πάνε καλά ή ένα κείμενο σφάλματος αν υπάρξει πρόβλημα
        public string Add(CourseModel course)
        {
            string error = string.Empty;
            var existed = Get(course.Id);
            if (existed != null)
            {
                return "Ο κωδικός υπάρχει ήδη στη βάση";
            }
            try
            {
                _context.Courses.Add(course);
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
        public string Delete(CourseModel course)
        {
            string error = string.Empty;
            try
            {
                _context.Courses.Remove(course);
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
        public CourseModel Get(Guid id)
        {
            return _context.Courses
                .Include(c => c.Subjects)
                .Include(c => c.Exam)
                .FirstOrDefault(x => x.Id == id);
        }

        //Η μέθοδός που επιστρέφει μια λίστα με όλα τα αντικείμενα που υπάρχουν στη βάση
        public List<CourseModel> GetAll()
        {
            return _context.Courses
                .Include(c => c.Subjects)
                .Include(c => c.Exam)
                .ToList();
        }

        //Η μέθοδος που θα ενημέρωση ένα αντικείμενο που υπάρχει στη βάση και επιστρέφει
        //ένα κενό κείμενο αν όλα πάνε καλά ή ένα κείμενο σφάλματος αν υπάρξει πρόβλημα
        public string Update(CourseModel course)
        {
            string error = string.Empty;
            try
            {
                _context.Courses.Update(course);
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
