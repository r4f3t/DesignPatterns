using ConsoleApp1.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Factory
{
    public abstract class DatabaseFactory
    {
        public abstract Connection CreateConnection();
        public abstract Command CreateCommand();
    }
}
