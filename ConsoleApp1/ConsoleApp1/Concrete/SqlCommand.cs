using ConsoleApp1.Abstract;
using System;

namespace ConsoleApp1.Concrete
{
    public class SqlCommand : Command
    {
        public override void Execute(string query) => Console.WriteLine("SqlCommand sorgusu çalıştırıldı.");
    }
}
