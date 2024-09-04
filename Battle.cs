using Core_Game.Interfaces;

namespace Core_Game
{
    internal class Battle
    {
        public Party Heroes { get; }
        public Party Monsters => _allMonsters[_currentRound];

        private List<Party> _allMonsters;
        private int _currentRound;

        public Battle(Party heroes, List<Party> monsters)
        {
            this.Heroes = heroes;
            _allMonsters = monsters;
            _currentRound = 0;
        }

        public void Run()
        {
            while (true)
            {
                RunParty(Heroes);
                if (IsHeroPartyEliminated || AreAllMonsterPartiesEliminated) break;
                if (IsCurrentMonsterPartyEliminated)
                {
                    AdvanceNextRound();
                    continue;
                }
                RunParty(Monsters);
                if (IsHeroPartyEliminated || AreAllMonsterPartiesEliminated) break;
                if (IsCurrentMonsterPartyEliminated)
                {
                    AdvanceNextRound();
                    continue;
                }
            }
            DisplayResult();
        }
        private void DisplayResult()
        {
            if (IsHeroPartyEliminated)
            {
                UberConsole.WriteLine("The Heroes lost and the Uncoded One's forces have prevailed!", ConsoleColor.Red);
            }
            else
            {
                UberConsole.WriteLine("The Heroes Won, and the Uncoded One was defeated", ConsoleColor.Magenta);
            }
        }
        private void AdvanceNextRound()
        {
            _currentRound++;
            UberConsole.WriteLine("This wave have been defeated, Advancing to the next wave...", ConsoleColor.Blue);
        }
        private bool IsRoundOver => IsHeroPartyEliminated || IsCurrentMonsterPartyEliminated;   
        private bool IsHeroPartyEliminated => Heroes.CharacterList.Count == 0;
        private bool IsCurrentMonsterPartyEliminated => Monsters.CharacterList.Count == 0;
        private bool AreAllMonsterPartiesEliminated => IsCurrentMonsterPartyEliminated && _currentRound == _allMonsters.Count - 1;

        private bool RunParty(Party party)
        {
            foreach (Character character in party.CharacterList.ToList())
            {
                
                if (!character.IsAlive) continue;

                BattleStatus(character);
                Console.WriteLine($"{character.Name} is taking a turn...");
                IAction chosenAction = party.Player.TakeTurn(this, character);
                chosenAction.Perform();
                handlePotentialDeath();

                if (IsRoundOver) break;

            }
            return true;
        }
        private void BattleStatus(Character current)
        {
            Console.WriteLine("============================================= BATTLE ============================================");
            foreach (Character hero in Heroes.CharacterList.ToList())
            {
                UberConsole.WriteLine($"{hero.Name,-38}{hero.CurrentHP,+3}/{hero.MaxHp,-3}", current == hero ? ConsoleColor.White : ConsoleColor.Yellow);
            }
            Console.WriteLine("---------------------------------------------- VS -----------------------------------------------");
            foreach (Character monster in Monsters.CharacterList.ToList())
            {
                UberConsole.WriteLine($"{monster.Name,+87}{monster.CurrentHP,+3}/{monster.MaxHp,-3}", current == monster ? ConsoleColor.White : ConsoleColor.Yellow);
            }
            Console.WriteLine("=================================================================================================");
        }

        private void handlePotentialDeath()
        {
            foreach (Character chara in Heroes.CharacterList.Concat(Monsters.CharacterList).ToList())
            {
                if (!chara.IsAlive)
                {
                    UberConsole.WriteLine($"{chara.Name} has been defeated!", ConsoleColor.Red);
                    Heroes.CharacterList.Remove(chara);
                    Monsters.CharacterList.Remove(chara);
                }
            }
        }
    }
}

