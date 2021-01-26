using GamerLogDemo.Entity;
using GamerLogDemo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerLogDemo.Manager
{
    class PlayerManager : ILoggerService
    {
        public void Add(IPerson person)
        {
            Console.WriteLine("This ID {0} and name {1} added to database", person.ID,person.Name);
        }

        public void Delete(IPerson person)
        {
            Console.WriteLine("This ID {0} and name {1} deleted from database",person.ID, person.Name);
        }

        public void Update(IPerson person)
        {
            Console.WriteLine("This ID {0} and name {1} updated to database", person.ID,person.Name);
        }
    }
}
