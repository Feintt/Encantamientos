using Logic.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Logic
{
    public struct EnchantmentProperties
	{
		public bool has_name;
		public bool has_description;
		public bool has_power;
		public bool has_treasure;
        public EnchantmentProperties(bool name, bool description, bool power, bool treasure)
		{
			has_name = false;
			has_description = false;
			has_power = false;
			has_treasure = false;
		}
	}

    public class Enchantments : EventsObjects
	{
		private List<TextBox> listOfProperties;

		public Enchantments(List<TextBox> listOfProperties)
		{
			this.listOfProperties = listOfProperties;
		}
		public Enchantments()
		{

		}
        private void AddEnchantment()
		{
            
        }
	}
}
