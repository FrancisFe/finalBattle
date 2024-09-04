using Core_Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game
{
    public abstract class Item
    {
        public abstract string Name { get;}

    }
    public class Potion : Item
    {
        public override string Name => "Potion";
    }
}
