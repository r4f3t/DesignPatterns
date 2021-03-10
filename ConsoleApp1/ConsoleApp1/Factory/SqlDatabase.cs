using ConsoleApp1.Abstract;
using ConsoleApp1.Concrete;

namespace ConsoleApp1.Factory
{
    //Concreate Factory
    class SqlDatabase : DatabaseFactory
    {
        public override Command CreateCommand() => new SqlCommand();
        public override Connection CreateConnection() => new SqlConnection();
    }
}
