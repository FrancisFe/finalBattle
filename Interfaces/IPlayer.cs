using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game.Interfaces
{
    internal interface IPlayer
    {
        public IAction TakeTurn(Battle battle, Character character);
    }
}
