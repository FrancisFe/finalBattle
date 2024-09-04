using Core_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game.Attacks
{
    internal class Punch:IAttack
    {
        public string Name => "PUNCH";

        public int Damage => 1;
    }
}
