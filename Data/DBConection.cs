using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DBConection : DataConnection
    {
        public DBConection() : base("BooksDataBase") { }
        public ITable<EnchantmentDB> enchantmentDBs { get { return GetTable<EnchantmentDB>(); } }
    }
}
