using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB;
using LinqToDB.Data;

namespace Data
{
    public class Connection : DataConnection
    {
        public Connection() : base("BooksDataBase") { }
        public ITable<EnchantmentsDB> enchantmentsSB { get { return GetTable<EnchantmentsDB>();  } }
    }
}
