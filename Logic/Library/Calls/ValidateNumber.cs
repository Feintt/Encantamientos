using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic.Library.Calls
{
    public class ValidateNumber
    {
        public bool KeyPressedIsNumber(KeyPressEventArgs e)
        {
            // We validate if the key pressed is a number
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
                return false;
            }
            // We validate if the key pressed is a letter
            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                return true;
            }
            // We validate if the key pressed is an enter
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                return true;
            }
            // We validate if the key pressed is a backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return false;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Space))
            {
                e.Handled = true;
                return true;
            }
            else
            {
                e.Handled = true;
                return true;
            }
        }
    }
}
