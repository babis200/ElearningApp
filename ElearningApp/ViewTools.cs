using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElearningApp
{
    public static class ViewTools
    {
        public static bool IsFormOpened<T>()
        {
            return Application.OpenForms.OfType<T>().Any();
        }

        //Η μέθοδος που θα επιστρέψει το πρώτο instance μια ανοιχτής φόρμας
        public static T GetOpenedForm<T>() where T : Form
        {
            return Application.OpenForms.OfType<T>().FirstOrDefault();
        }
    }
}
