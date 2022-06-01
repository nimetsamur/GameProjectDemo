using GameProjectDemo.Adapters;
using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer()
            {
                GamerId = 1,
                NationalityId = 12345678912,
                GamerFirstName = "Nimet",
                GamerLastName = "Samur",
                UserName = "nimetsamur",
                DateOfBirth = new DateTime(, , )

            };
            Gamer gamer2 = new Gamer()
            {
                GamerId = 2,
                NationalityId = 12345678914,
                GamerFirstName = "Semih",
                GamerLastName = "Samur",
                UserName = "semihsamur",
                DateOfBirth = new DateTime(, , )

            };

            

            Game game1 = new Game()
            {
                GameId = 1,
                GameName = "FIFA22",
                GamePrice = 119.90
            };
            Game game2 = new Game()
            {
                GameId = 2,
                GameName = "The Witcher 3",
                GamePrice = 59.99
            }; 

            

            Campaign campaign1 = new Campaign()
            {
                CampaignId = 1,
                CampaignName = "Mayıs Kampanyası",
                Discount = 30
            };

            Campaign campaign2 = new Campaign()
            {
                CampaignId = 2,
                CampaignName = "Tatil Kampanyası",
                Discount = 20
            };

            MernisServiceAdapter mernisServiceAdapter = new MernisServiceAdapter();
            GamerManager gamerManager = new GamerManager(mernisServiceAdapter);
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);

            gamer1.UserName = "nmtsmr";
            gamerManager.Update(gamer1);

            SaleManager sale = new SaleManager();
            sale.Sale(game1, gamer1);
            sale.DiscountSale(game1, gamer1, campaign1);
            sale.DiscountSale(game2, gamer1, campaign2);


            



        }
    }
}
