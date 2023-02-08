using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.pokemons
{
    internal class Pichu : Pokemon
    {
        public Pichu()
        {
            this.name = "Pichu";
            Random random = new Random();
            //random number between >= 200 and <295
            this.HP = random.Next(150, 244);
            this._image = Properties.Resources._172;
            this.Attack = random.Next(85, 174);
            this.Defense = random.Next(67, 185);
        }
    }
}
