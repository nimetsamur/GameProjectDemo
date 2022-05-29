using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Entities
{
    public class Gamer:IEntities
    {
        public int GamerId { get; set; }
        public long NationalityId { get; set; }
        public string GamerFirstName { get; set; }
        public string GamerLastName { get; set; }
        public string UserName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
