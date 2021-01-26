using System;
using System.Collections.Generic;
using System.Text;

namespace GamerLogDemo
{
    public interface IPerson
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string IdentifyNum { get; set; }
        public int DateTime { get; set; }
    }
}
