// In this class, for every single class that we create, we will create an instance of that class
// So we will be able to use the methods from any class
// By creating a new instance of the Enchantments class

using Logic.Library.Calls;

namespace Logic.Library
{
    public class EventsObjects
    {
        // We create an object of the class "ValidateNumber"
        public ValidateLetter validateLetter = new ValidateLetter();
        // We create an object of the class "ValidateNumber"
        public ValidateNumber validateNumber = new ValidateNumber();
        // We create an object of the struct "EnchantmentProperties" from the class "ButtonUnlocks"
        public EnchantmentProperties enchantmentProperties = new EnchantmentProperties(false, false, false, false);
        // We create an object of the class "ButtonUnlocks"
        public ButtonUnlock buttonUnlocks = new ButtonUnlock();
        // We create an object of the class "DBlogic"
        public DBlogic dBlogic = new DBlogic();
    }
}
