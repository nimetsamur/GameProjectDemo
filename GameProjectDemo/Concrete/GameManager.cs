using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Game added : " + game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Game deleted : " + game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Game updated : " + game.GameName);
        }
    }
}
