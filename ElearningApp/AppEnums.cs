using System.ComponentModel;

namespace ElearningApp
{
    public class AppEnums
    {
        public enum Work
        {
            [Description("Προσθήκη")]
            Add,
            [Description("Επεξεργασία")]
            Edit,
            [Description("Προβολή")]
            Preview
        }
    }
}
