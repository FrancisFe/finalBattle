using Core_Game.Actions;
using Core_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game
{
    internal class ComputerIAPlayer : IPlayer
    {
        Random _random = new Random();
        public IAction TakeTurn(Battle battle, Character character)
        {
            Thread.Sleep(500);

            List<Potion> potions = FindItems(battle, character).OfType<Potion>().ToList();

            if (character.CurrentHP / (float)character.MaxHp <= 0.5f && _random.NextDouble() < 0.25f && potions.Count > 0)
                return new UseItem(character, potions[0]);


            List<Character> potentialTargets = FindTargets(battle,character);
            if (potentialTargets.Count == 0) return new DoNothingAction(character);


            Character target = potentialTargets[_random.Next(potentialTargets.Count)];
            return new Attack(character, character.BasicAttack, target);

        }
        private static List<Item> FindItems(Battle battle, Character character)
        {
            if (battle.Monsters.CharacterList.Contains(character)) return battle.Heroes.Items;
            else return battle.Monsters.Items;
        }
        private static List<Character> FindTargets(Battle battle, Character character)
        {
            if (battle.Monsters.CharacterList.Contains(character)) return battle.Heroes.CharacterList;
            else return battle.Monsters.CharacterList;
        }
    }
}
