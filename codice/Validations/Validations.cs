using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace codice.Validations
{
    public static class Validate
    {
        public static bool InputsValidate(
            Dictionary<string, string?> fields)
        {
            foreach (var field in fields)
            {
                if (string.IsNullOrWhiteSpace(field.Value))
                {
                    MessageBox.Show($"{field.Key} requerido");
                    return false;
                }
            }

            return true;
        }

        public static void IsActiveBtnStyle(Button btn, bool state)
        {
            if (state)
            {
                btn.Enabled = true;

                btn.BackColor = Color.FromArgb(37, 97, 235);
                btn.ForeColor = Color.White;

            }
            else
            {
                btn.Enabled = false;

                btn.BackColor = Color.FromArgb(180, 180, 180);
                btn.ForeColor = Color.White;
            }

        }
    }
}