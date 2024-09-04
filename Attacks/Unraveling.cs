using Core_Game.Interfaces;

namespace Core_Game.Attacks
{
    internal class Unraveling : IAttack
    {
        public string Name => "Unraveling";
        public static readonly Random _random = new Random();
        public int Damage => _random.Next(2);

    }
}
