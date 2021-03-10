using ConsoleApp1.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Concrete
{
    public class SqlConnection : Connection
    {
        public override string State => "Open";

        public override bool Connect()
        {
            Console.WriteLine("SqlConnection bağlantısı kuruluyor.");
            return true;
        }

        public override bool DisConnect()
        {
            Console.WriteLine("SqlConnection bağlantısı kesiliyor.");
            return false;
        }
    }
}
