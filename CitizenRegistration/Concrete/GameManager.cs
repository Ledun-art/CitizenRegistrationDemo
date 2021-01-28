using System;
using System.Collections.Generic;

namespace CitizenRegistration
{
    internal class GameManager : IProduct
    {
        public void Add()
        {
            var games1 = GamesList(out var games2);

            List<Games> gamesList = new List<Games>();
            gamesList.Add(games1);
            gamesList.Add(games2);

            foreach (Games gameing in gamesList)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Oyun İsmi : " + gameing.GameName);
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Çıkış Yılı: " + gameing.GameYear);
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Satış Fiyatı " + gameing.GamePrice);
            }
        }


        public void Delete()
        {
            var games1 = GamesList(out var games2);
            List<Games> gamesListDelete = new List<Games>();
            gamesListDelete.Add(games1);
            gamesListDelete.Add(games2);

            foreach (Games gameing in gamesListDelete)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Oyun İsmi : " + gameing.GameName);
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Çıkış Yılı: " + gameing.GameYear);
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Satış Fiyatı " + gameing.GamePrice);
            }

            Console.WriteLine("Silmek istediğin oyun ismini yaz !");
            Console.WriteLine("Oyun ismi");
            string deleteGame = Console.ReadLine();
            if (deleteGame == "ARK")
            {
                Console.WriteLine("Oyun Listeden silindi" + " " + games1.GameName);
                gamesListDelete.Remove(games1);
            }
            else if (deleteGame == "Death Stranding")
            {
                Console.WriteLine("Oyun Listeden silindi" + " " + games2.GameName);
                gamesListDelete.Remove(games2);
            }
            else
            {
                Console.WriteLine("Listede olmayan bir seçim yaptınız");
            }
        }
        

        private static Games GamesList(out Games games2)
        {
            Games games1 = new Games();
            games1.GameName = "ARK";
            games1.GamePrice = "100";
            games1.GameYear = "2012";

            games2 = new Games();
            games2.GameName = "Death Stranding";
            games2.GamePrice = "200";
            games2.GameYear = "2018";
            return games1;
        }
    }
}