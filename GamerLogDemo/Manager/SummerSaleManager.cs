using GamerLogDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerLogDemo.Manager
{
    class SummerSaleManager : ICampaignService
    {
        int gamePrice;
        public void Calculate(List<Game> games)
        {
            foreach (var game in games)
            {
                gamePrice = (int)(game.Price * 80) / 100;
                game.Price = gamePrice;
            }

        }
        public void ListGame(List<Game> games)
        {
            Console.WriteLine("İndirimli Fiyatlar:");
            foreach (var sale in games)
            {                
                Console.WriteLine("{0} isimli oyunun fiyatı: {1} ",sale.Name, sale.Price);
              
            }
        }
    }
}
