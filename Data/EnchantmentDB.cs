using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Data
{

    public class EnchantmentDB
    {        
        // We create a varibale for each column in the table
        public int id { get; set; }
        public string eName { get; set; }
        public string eDescription { get; set; }
        public string ePower { get; set; }
        public string eTreasure { get; set; }
    }
}
