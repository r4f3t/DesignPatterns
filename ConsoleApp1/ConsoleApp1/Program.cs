using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var object1 = Singleton.GetObject();
            var object2 = Singleton.GetObject();

            if (object1==object2)
            {
                Console.WriteLine("Objeler eşit");
            }


            if (object1.Equals(object2))
            {
                Console.WriteLine("Objeler epeşit");
            }


            if (object1.GetHashCode() == object2.GetHashCode())
            {
                Console.WriteLine("Objeler epepeşit");
            }


            Console.ReadLine();
        }
    }


    class Singleton
    {
        private Singleton()
        {

        }

        private static Singleton _singleton;
        public static Singleton  GetObject()
        {
            if (_singleton == null)
            {
                _singleton = new Singleton();
            }
            return _singleton;
        }
    }
}
