using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintLabel.App.Controls
{
    public class usCommon
    {
        public static void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) /*&& (e.KeyChar != '.')*/)
            {
                e.Handled = true;
            }

            //// only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}

        }

        public static void txtQuantity_Validating(object sender, System.ComponentModel.CancelEventArgs e,
            Control txtQuantity, ErrorProvider errorProvider1)
        {
            if (txtQuantity.Text != "")
            {
                if (FieldError(txtQuantity,errorProvider1) == true)
                {
                    double qty = double.Parse(txtQuantity.Text);
                    if (qty > 999999)
                    {
                        errorProvider1.Clear();
                        errorProvider1.SetError(txtQuantity, "Value maximum!");
                        return;
                    }
                }
            }

        }

        public static void txtQuantity_TextChanged(object sender, EventArgs e, ErrorProvider errorProvider1)
        {
            errorProvider1.Clear();
        }

        public static  bool WOError(Control control, ErrorProvider errorProvider1)
        {
            if (control.Text == "" || control.Text == null || control.Text.Length != 10)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(control, "Required field!");
                control.Focus();
                return false;
            }
            return true;
        }
        public static bool FieldError(Control control, ErrorProvider errorProvider1)
        {
            if (control.Text == "" || control.Text == null)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(control, "Required field!");
                control.Focus();
                return false;
            }
            return true;
        }
    }
}
