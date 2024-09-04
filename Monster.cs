using Core_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game
{
    internal abstract class Monster : Character
    {
        protected Monster(int hp) : base(hp)
        {
        }

        public override string Name { get; }
        public override IAttack BasicAttack { get; }


    }
}
