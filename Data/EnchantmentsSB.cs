using LinqToDB.Mapping;

namespace Data
{
    public class EnchantmentsDB
    {
        [PrimaryKey, Identity]
        // We create a varibale for each column in the table
        public int id { set; get; }
        public string eName { set; get; }
        public string eDescription { set; get; }
        public string ePower { set; get; }
        public string eTreasure { set; get; }
    }
}
