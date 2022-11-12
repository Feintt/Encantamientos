using Logic.Library.Calls;

namespace Logic.Library
{
    public class EventsObjects
    {
        // We cretae an object of the class "UploadImage"
        public UploadImage uploadImage = new UploadImage();
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
