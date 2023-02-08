using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.pokemons
{
    internal class Froakie : Pokemon
    {
        public Froakie()
        {
            this.name = "Froakie";
            Random random = new Random();
            //random number between >= 200 and <295
            this.HP = random.Next(192, 286);
            this._image = Properties.Resources._656;
            this.Attack = random.Next(105, 232);
            this.Defense = random.Next(76, 196);
        }
    }
}
