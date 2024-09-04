using Core_Game.Interfaces;

namespace Core_Game.Actions
{
    internal class Attack : IAction
    {
        private readonly IAttack _attack;
        private readonly Character _target;
        private readonly Character _character;
        public Attack(Character character, IAttack attack, Character target)
        {
            _character = character;
            _attack = attack;
            _target = target;
        }

        public void Perform()
        {
            Console.WriteLine($"{_character.Name} used {_attack.Name} on {_target.Name}");
            _target.CurrentHP -= _attack.Damage;
            Console.WriteLine($"{_attack.Name} dealt {_attack.Damage} to {_target.Name}");
            Console.WriteLine($"{_target.Name} is now at {_target.CurrentHP}/{_target.MaxHp}HP");
        }
    }
}
