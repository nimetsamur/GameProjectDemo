using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface ISaleService
    {
        void Sale(Game game,Gamer gamer);
        void DiscountSale(Game game,Gamer gamer,Campaign campaign);
    }
}
