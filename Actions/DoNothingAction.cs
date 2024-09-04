using Core_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game.Actions
{
    internal class DoNothingAction : IAction
    {
        private Character _character;
        public DoNothingAction(Character character) => _character = character;
        public void Perform() => Console.WriteLine($"{_character.Name} Did NOTHING!");
    }
}
