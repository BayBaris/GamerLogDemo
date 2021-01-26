using GamerLogDemo.Interface;
using GamerLogDemo.Entity;
using GamerLogDemo.Manager;
using System;
using System.Collections.Generic;

namespace GamerLogDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson person1 = new Player { Name = "Barış",LastName = "Karakaya",IdentifyNum = "45745864813" ,DateTime = 2000,ID = 1547};
            IPerson person2 = new Player { Name = "Engin", LastName = "Demiroğ", IdentifyNum = "12548768874",DateTime = 1985, ID = 2575};
            IPerson person3 = new Player { Name = "Nazlı", LastName = "Küçükağ", IdentifyNum = "21546787264", DateTime = 1998,ID = 4576};
            Game game1 = new Game { Name = "COD MW", Category = "Action", Price = 160, ID = 1 };
            Game game2 = new Game { Name = "SpeedRunner", Category = "Platform", Price = 30, ID = 2 };
            Game game3 = new Game { Name = "Dark Soul", Category = "RPG", Price = 120, ID = 3 };

            List<Game> games = new List<Game> { game1, game2, game3 };
            List<IPerson> players = new List<IPerson> { person1, person2 };
            int section = 99;

            while (section != 0)
            {
                Console.WriteLine("Choose Operation:\n" +
                    "[1] PlayerManager\n" +
                    "[2] GameManager\n" +
                    "[3] MernisManager\n" +
                    "[4] SummerSale\n" +
                    "[0] Exit");
                section = Convert.ToInt32(Console.ReadLine());
                if (section == 1)
                {
                    PlayerManager playerManager = new PlayerManager();
                    playerManager.Add(person1);
                    playerManager.Add(person2);
                    Console.WriteLine("Add Metotu Çalıştı");
                    Console.WriteLine("--------------------");
                    playerManager.Delete(person3);
                    Console.WriteLine("Delete metotu Çalıştı");
                    Console.WriteLine("--------------------");
                    playerManager.Update(person2);
                    Console.WriteLine("Update metotu çalıştı");
                    Console.WriteLine("--------------------");

                }
                else if (section == 2)
                {
                    GameManager gameManager = new GameManager();
                    gameManager.Buy(game1, person1);
                    Console.WriteLine("Buy Metotu Çalıştı");
                    Console.WriteLine("--------------------");
                    gameManager.ListGame(games);
                    Console.WriteLine("Oyunlar listelendi");
                    Console.WriteLine("--------------------");
                    gameManager.Calculate(games);
                    gameManager.ListGame(games);
                    Console.WriteLine("İndirimli Fiyatlar Listelendi");
                    Console.WriteLine("--------------------");
                }
                else if (section == 3)
                {
                    MernisManager mernisManager = new MernisManager();
                    mernisManager.Verify(person1);
                }
                else if (section == 4)
                {
                    ICampaignService summerSale = new SummerSaleManager();
                    summerSale.Calculate(games);
                    summerSale.ListGame(games);

                }
                else if (section == 0)
                {
                    break;
                }
            }
            

          


        }
    }
}
