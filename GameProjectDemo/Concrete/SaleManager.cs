using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class SaleManager : ISaleService
    {
        public void DiscountSale(Game game, Gamer gamer, Campaign campaign)
        {
            double newPrice = game.GamePrice - ((game.GamePrice*campaign.Discount)/100);
            Console.WriteLine(gamer.UserName+" bought the "+game.GameName+" with "+campaign.Discount+" sale!");
            Console.WriteLine("The price of game : "+ newPrice);
        }

        public void Sale(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.UserName + " bought the " + game.GameName + " ! ");
            Console.WriteLine("The price of game : "+game.GamePrice);
        }
    }
}
