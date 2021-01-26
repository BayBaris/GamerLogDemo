using GamerLogDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerLogDemo.Manager
{
    public class MernisManager
    {
        public void Verify(IPerson player)
        {
            if((player.IdentifyNum).Length == 11 && player.DateTime > 1900)
            {
                Console.WriteLine("This person is real: " + player.Name);
                Console.WriteLine("Person's Informations:\n" +
                    "Name: {0}\n" +
                    "Surname: {1}\n" +
                    "Identify Number: {2}\n" +
                    "Date Year: {3}",player.Name,player.LastName,player.IdentifyNum,player.DateTime);
            }
            else
            {
                throw new SystemException("Person is not real");
            }
        }
    }
}
