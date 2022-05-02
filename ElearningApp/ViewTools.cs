using MaterialSkin2DotNet.Controls;

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

        //Η μέθοδος που τσεκάρει τα editable και enabled controls μιας φόρμα και τα απενεργοποιεί
        public static void ReadOnlyAll(Control control)
        {
            foreach (var ctr in control.Controls)
            {
                if (ctr is MaterialTextBox)
                    (ctr as MaterialTextBox).ReadOnly = true;
                else if (ctr is MaterialComboBox)
                    (ctr as MaterialComboBox).Enabled = false;
                else if (ctr is MaterialSwitch)
                    (ctr as MaterialSwitch).Enabled = false;
                else if (ctr is MaterialButton)
                    (ctr as MaterialButton).Enabled = false;
                else if (ctr is TextBox)
                    (ctr as TextBox).ReadOnly = true;
                else if (ctr is ComboBox)
                    (ctr as ComboBox).Enabled = false;
                else if (ctr is CheckBox)
                    (ctr as CheckBox).Enabled = false;
                else if (ctr is Button)
                    (ctr as Button).Enabled = false;
                else if (ctr is DateTimePicker)
                    (ctr as DateTimePicker).Enabled = false;
            }
        }
    }
}
