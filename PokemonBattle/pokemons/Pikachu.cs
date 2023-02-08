using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.pokemons
{
    internal class Pikachu : Pokemon
    {
        public Pikachu()
        {
            this.name = "Pikachu";
            Random random = new Random();
            //random number between >= 200 and <295
            this.HP = random.Next(180, 274);
            this._image = Properties.Resources._025;
            this.Attack = random.Next(103, 229);
            this.Defense = random.Next(76, 196);
        }
    }
}
