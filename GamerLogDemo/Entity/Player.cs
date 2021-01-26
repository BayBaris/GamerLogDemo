using System;
using System.Collections.Generic;
using System.Text;
using GamerLogDemo.Interface;

namespace GamerLogDemo.Entity
{
    public class Player : IPerson
    {
        public int ID { get ; set ; }
        public string Name { get ; set ; }
        public string LastName { get; set; }
        public string IdentifyNum { get; set; }
        public int DateTime { get; set; }
    }
}
