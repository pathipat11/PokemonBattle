using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.pokemons
{
    internal class Mewtwo : Pokemon
    {
        public Mewtwo()
        {
            this.name = "Mewtwo";
            Random random = new Random();
            //random number between >= 200 and <295
            this.HP = random.Next(322, 416);
            this._image = Properties.Resources._150;
            this.Attack = random.Next(202, 350);
            this.Defense = random.Next(166, 306);
        }
    }
}
