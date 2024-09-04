using Core_Game.Attacks;
using Core_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game
{
    internal class Heroe : Character
    {
        public override string Name { get; }
        public override IAttack BasicAttack { get; } = new Punch();

        public Heroe(string name ) :base(25) => Name = name;

        
      
    }
}

