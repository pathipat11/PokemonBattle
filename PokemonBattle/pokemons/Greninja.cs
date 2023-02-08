using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.pokemons
{
    internal class Greninja : Pokemon
    {
        public Greninja()
        {
            this.name = "Greninja";
            Random random = new Random();
            //random number between >= 200 and <295
            this.HP = random.Next(254, 348);
            this._image = Properties.Resources._658;
            this.Attack = random.Next(175, 317);
            this.Defense = random.Next(125, 256);
        }
    }
}
