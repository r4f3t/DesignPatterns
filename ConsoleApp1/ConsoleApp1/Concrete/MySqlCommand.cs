using ConsoleApp1.Abstract;
using System;

namespace ConsoleApp1.Concrete
{
    public class MySqlCommand : Command
    {
        public override void Execute(string query) => Console.WriteLine("MySqlCommand sorgusu çalıştırıldı.");
    }
}
