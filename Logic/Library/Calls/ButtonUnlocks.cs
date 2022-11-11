using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic.Library.Calls
{
    public struct EnchantmentProperties
    {
        public bool has_name;
        public bool has_description;
        public bool has_power;
        public bool has_treasure;
        public EnchantmentProperties(bool has_name, bool has_description, bool has_power, bool has_treasure)
        {
            this.has_name = has_name;
            this.has_description = has_description;
            this.has_power = has_power;
            this.has_treasure = has_treasure;
        }
    }
    public class ButtonUnlocks
    {
        public void EnchantmentHasProperties(Enchantments e, Button button)
        {
            if (e.enchantmentProperties.has_name && e.enchantmentProperties.has_description && e.enchantmentProperties.has_treasure && e.enchantmentProperties.has_power)
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
