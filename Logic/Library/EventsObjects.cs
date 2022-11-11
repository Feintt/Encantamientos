using Logic.Library.Calls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        //We create an object of the struct "EnchantmentProperties" from the class "ButtonUnlocks"
        public EnchantmentProperties enchantmentProperties = new EnchantmentProperties(false, false, false, false);
        //We create an object of the class "ButtonUnlocks"
        public ButtonUnlocks buttonUnlocks = new ButtonUnlocks();
    }
}
