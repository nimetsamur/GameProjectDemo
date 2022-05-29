using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class GamerManager : IGamerService
    {
        IPersonCheckService _personCheckService;
        public GamerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }
        public void Add(Gamer gamer)
        {
            if (_personCheckService.CheckIfRealPErson(gamer))
            {
                Console.WriteLine("Gamer added : " + gamer.UserName);
            }
            else
            {
                Console.WriteLine("Not a valid person");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer deleted : " + gamer.UserName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer updated : " + gamer.UserName);
        }
    }
}
