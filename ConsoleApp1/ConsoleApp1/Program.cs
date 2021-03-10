using ConsoleApp1.Factory;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var creater = new Creater(new SqlDatabase());
            creater.Start();

            Console.WriteLine();

            creater = new Creater(new MySqlDatabase());
            creater.Start();

            Console.ReadLine();
        }
    }
}
