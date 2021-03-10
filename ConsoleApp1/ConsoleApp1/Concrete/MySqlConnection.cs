using ConsoleApp1.Abstract;
using System;

namespace ConsoleApp1.Concrete
{
    //Concrete Product
    public class MySqlConnection : Connection
    {
        public override string State => "Open";
        public override bool Connect()
        {
            Console.WriteLine("MySqlConnection bağlantısı kuruluyor.");
            return true;
        }
        public override bool DisConnect()
        {
            Console.WriteLine("MySqlConnection bağlantısı kesiliyor.");
            return false;
        }
    }
}
