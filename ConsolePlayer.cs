using Core_Game.Actions;
using Core_Game.Interfaces;

namespace Core_Game
{
    internal class ConsolePlayer : IPlayer
    {
        public IAction TakeTurn(Battle battle, Character character)
        {
            while (true)
            {
                Console.WriteLine("1- Basic Attack");
                Console.WriteLine("2- Do Nothing");
                Console.WriteLine("What do you want to do");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice == 1) return new Attack(character, character.BasicAttack, FindTargets(battle, character)[0]);
                    else if (choice == 2) return new DoNothingAction(character);
                }
                Console.WriteLine("I didnt understand that input");
            }
        }
        private static List<Character> FindTargets(Battle battle, Character character)
        {
            if (battle.Monsters.CharacterList.Contains(character)) return battle.Heroes.CharacterList;
            else return battle.Monsters.CharacterList;
        }
    }
}
