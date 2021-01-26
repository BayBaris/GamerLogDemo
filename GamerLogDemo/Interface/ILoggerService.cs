using System;
using System.Collections.Generic;
using System.Text;

namespace GamerLogDemo.Interface
{
    public interface ILoggerService
    {
        void Add(IPerson person);
        void Delete(IPerson person);
        void Update(IPerson person);

    }
}
