using Data;
using LinqToDB;
using Logic.Library;
using System.Collections.Generic;
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
        private EventsObjects eventsObjects = new EventsObjects();

        public Enchantments(List<TextBox> listOfProperties)
        {
            this.listOfProperties = listOfProperties;
        }
        public Enchantments()
        {

        }
        public void AddEnchantment(List<TextBox> properties) 
        {
            Connection db = new Connection();
            db.Insert(new EnchantmentsDB()
            {
                eName = listOfProperties[0].Text,
                eDescription = listOfProperties[1].Text,
                ePower = listOfProperties[2].Text,
                eTreasure = listOfProperties[3].Text
            });
        }
    }
}
