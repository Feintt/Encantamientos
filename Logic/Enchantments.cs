// This is the main class of the Logic Layer
// We will manage all the logic of the application here
// By creating methods that will be called from the UI Layer
// All this methods will be inherited by the Library folder, which is the main folder that contains the most important methods of the application

using Logic.Library;


namespace Logic
{

    // We will create an struct to validate whenever the enchantment has all the properties
    // In order to use the button to add the enchantment
    public struct EnchantmentProperties
    {
        public bool has_name;
        public bool has_description;
        public bool has_power;
        public bool has_treasure;

        // Ww will define the constructor of the struct
        // Setting all the properties to false
        public EnchantmentProperties(bool name, bool description, bool power, bool treasure)
        {
            has_name = false;
            has_description = false;
            has_power = false;
            has_treasure = false;
        }
    }


    // This is a very important step
    // We will inherit the class EventsObjects from the Library folder, so every method that we create calling the Enchantments class
    // will be able to use the methods from the EventsObjects class 
    public class Enchantments : EventsObjects
    {
        public Enchantments()
        {

        }
    }
}
