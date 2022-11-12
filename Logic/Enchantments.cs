using Logic.Library;


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
        public Enchantments()
        {

        }
    }
}
