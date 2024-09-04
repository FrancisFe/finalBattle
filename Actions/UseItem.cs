using Core_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game.Actions
{
    internal class UseItem : IAction
    {
        private readonly Character _character;
        private readonly Item _item;
        public UseItem(Character character, Item item)
        {
            _character = character;
            _item = item;
        }

        public void Perform()
        {
            Console.WriteLine($"{_character.Name} used {_item.Name}");
            _character.CurrentHP += 10;
            Console.WriteLine($"{_character.Name} gained 10HP");
            UberConsole.WriteLine($"{_character.Name} is now at {_character.CurrentHP}/{_character.MaxHp}HP", ConsoleColor.Magenta);
        }
    }
}
