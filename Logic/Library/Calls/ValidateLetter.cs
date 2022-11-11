using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic.Library
{
    public class ValidateLetter
    {
        public bool KeyPressedIsLetter(KeyPressEventArgs e)
        {
            // We validate if the key pressed is a letter
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
                return false;
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
            // We valiate if the key pressed is a backspace
            else if (e.KeyChar == Convert.ToChar(Keys.Space))
            {
                e.Handled = false;
                return false;
            }
            else
            {
                e.Handled = true;
                return true;
            }
        }
    }
}
