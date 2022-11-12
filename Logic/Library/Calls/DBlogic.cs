using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;
using LinqToDB;

namespace Logic.Library.Calls
{
    public class DBlogic : Connection
    {
        public void AddEnchantment(List<TextBox> ListOfProperties)
        {
            Connection db = new Connection();
            db.Insert(new EnchantmentsDB()
            {
                eName = ListOfProperties[0].Text,
                eDescription = ListOfProperties[1].Text,
                ePower = ListOfProperties[2].Text,
                eTreasure = ListOfProperties[3].Text
            });
        }
    }
}
