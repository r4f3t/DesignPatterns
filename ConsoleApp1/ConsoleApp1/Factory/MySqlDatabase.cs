using ConsoleApp1.Abstract;
using ConsoleApp1.Concrete;

namespace ConsoleApp1.Factory
{
    class MySqlDatabase : DatabaseFactory
    {
        public override Command CreateCommand() => new MySqlCommand();
        public override Connection CreateConnection() => new MySqlConnection();
    }
}
