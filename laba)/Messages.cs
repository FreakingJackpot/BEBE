using System.Windows.Forms;

namespace laba_
{
    public class Messages
    {
        public static DialogResult DeleteMessage()
        {
            string message = "Delete this item ?";
            string error = "Delete Message";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, error, buttons);
            return result;
        }

        public static void EmptyOrIncorrect()
        {
            string message = "fields empty or incorrect";
            string error = "Error";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, error, buttons);
        }
    }
}
