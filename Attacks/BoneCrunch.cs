using Core_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game.Attacks
{
    internal class BoneCrunch: IAttack
    {
        public string Name => "Bone Crunch";
        public static readonly Random _random = new Random();
        public int Damage => _random.Next(2);
    }
}
