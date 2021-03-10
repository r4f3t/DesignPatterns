using ConsoleApp1.Abstract;
using ConsoleApp1.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Creater
    {
        public DatabaseFactory _databaseFactory;
        public Connection _connection;
        public Command _command;

        public Creater(DatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
            _connection = _databaseFactory.CreateConnection();
            _command = _databaseFactory.CreateCommand();
        }

        public void Start()
        {
            if (_connection.State == "Open")
            {
                _connection.Connect();
                _command.Execute("Select * from...");
                _connection.DisConnect();
            }
        }
    }
}
