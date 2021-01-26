using GamerLogDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerLogDemo
{
    class GameManager : ICampaignService 
    {
        //int tempPrice;
        int gamePrice;
        public void Buy(Game game,IPerson person)
        {
            Console.WriteLine("{0} sepete başarı ile eklendi.",game.Name);
            Console.WriteLine("{0} tarafından alındı.",person.Name);
        }

        public void Calculate(List<Game> games)
        {
            foreach (var game in games)
            {
                if (game.Price > 0 && game.Price <= 50)
                {                    
                    gamePrice = (int) (game.Price * 90) / 100;
                    game.Price = gamePrice;

                }
                else if (game.Price > 50 && game.Price <= 100)
                {
                    gamePrice = (int)(game.Price * 75) / 100;
                    game.Price = gamePrice;
                }
                else
                {
                    gamePrice = (int)(game.Price * 70) / 100;
                    game.Price = gamePrice;
                }
            }
            
        }

        public void ListGame(List<Game> games)
        {
            Console.WriteLine("List of Game:");
            foreach (var game in games)
            {
                Console.WriteLine("ID:{0}\nGame:{1}\nCategory:{2}\nPrice:{3}",game.ID,game.Name,game.Category,game.Price);
            }
        }
       
    }
}
