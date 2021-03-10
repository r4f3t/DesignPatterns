using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Abstract
{
    //Abstract Product
    public abstract class Connection
    {
        public abstract bool Connect();
        public abstract bool DisConnect();
        public abstract string State { get; }
    }
}
