using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface IPersonCheckService
    {
        bool CheckIfRealPErson(Gamer gamer);
    }
}
