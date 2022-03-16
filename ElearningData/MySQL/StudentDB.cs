using ElearningData.Interfaces;

using ElearningModels.Models;
using ElearningModels.Models.Users;

using Microsoft.EntityFrameworkCore;

namespace ElearningData.MySQL
{
    public class StudentDB : IStudentRepo
    {
        ElearningDBContext _context;

        public StudentDB(ElearningDBContext context)
        {
            _context = context;
        }

        //Η μέθοδος που προσθέτει ένα αντικείμενο στη βάση και επιστρέφει
        //ένα κενό κείμενο αν όλα πάνε καλά ή ένα κείμενο σφάλματος αν υπάρξει πρόβλημα
        public string Add(StudentModel student)
        {
            string error = string.Empty;
            var existed = Get(student.Id);
            if (existed != null)
            {
                return "Ο κωδικός υπάρχει ήδη στη βάση";
            }
            try
            {
                _context.Students.Add(student);
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
        public string Delete(StudentModel student)
        {
            string error = string.Empty;
            try
            {
                _context.Students.Remove(student);
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
        public StudentModel Get(int id)
        {
            return _context.Students
                .Include(c => c.Courses)
                .First(x => x.Id == id);
        }

        //Η μέθοδός που επιστρέφει μια λίστα με όλα τα αντικείμενα που υπάρχουν στη βάση
        public List<StudentModel> GetAll()
        {
            return _context.Students
                .Include(c => c.Courses)
                .ToList();
        }

        //Η μέθοδος που θα ενημέρωση ένα αντικείμενο που υπάρχει στη βάση και επιστρέφει
        //ένα κενό κείμενο αν όλα πάνε καλά ή ένα κείμενο σφάλματος αν υπάρξει πρόβλημα
        public string Update(StudentModel student)
        {
            string error = string.Empty;
            try
            {
                _context.Students.Update(student);
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
