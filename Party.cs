using Core_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game
{
    internal class Party
    {
        public IPlayer Player { get; }
        public List<Character> CharacterList = new List<Character>();
        public List<Item> Items { get; }

        public Party(IPlayer player, IEnumerable<Item> StartingItems)
        {
            this.Player = player;
            Items = StartingItems.ToList();
        }

        public void AddCharacter(Character character)
        {
            CharacterList.Add(character);
        }

    }
}
