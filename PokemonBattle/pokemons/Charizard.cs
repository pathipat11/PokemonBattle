using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.pokemons
{
    internal class Charizard : Pokemon
    {
        public Charizard()
        {
            this.name = "Charizard";
            Random random = new Random();
            //random number between >= 200 and <295
            this.HP = random.Next(266, 360);
            this._image = Properties.Resources._006;
            this.Attack = random.Next(155, 293);
            this.Defense = random.Next(144, 280);
        }
    }
}
