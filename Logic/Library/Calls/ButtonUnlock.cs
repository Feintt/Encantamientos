using System.Windows.Forms;

namespace Logic.Library.Calls
{
    public class ButtonUnlock
    {
        public void buttonUnlocks(EnchantmentProperties e, Button button)
        {
            if (e.has_name && e.has_description && e.has_power && e.has_treasure)
            {
                button.Enabled = true;
            }
            else
            {
                button.Enabled = false;
            }
        }
    }
}
