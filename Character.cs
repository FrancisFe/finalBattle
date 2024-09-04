using Core_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game
{
    internal abstract class Character
    {
        public abstract string Name { get; }
        public int _currentHP { get; set; }
        public int MaxHp { get; }

        public bool IsAlive => CurrentHP > 0;
        public abstract IAttack BasicAttack { get; }

        public int CurrentHP
        {
            get { return _currentHP; }
            set { _currentHP = Math.Clamp(value, 0 ,MaxHp); }
        }

        public Character(int hp)
        {
            MaxHp = hp;
            CurrentHP = hp;
        }
    }
}
