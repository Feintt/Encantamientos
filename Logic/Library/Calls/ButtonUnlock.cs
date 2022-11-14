using System.Windows.Forms;

namespace Logic.Library.Calls
{
    public class ButtonUnlock
    {
        public void buttonUnlocks(EnchantmentProperties e, Button button)
        {
            // We check if the enchantment has all the properties
            // If it has all the properties, we will enable the button to add the enchantment
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
