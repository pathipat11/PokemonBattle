using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.pokemons
{
    internal class Pokemon
    {
        protected string name;
        protected int HP;
        protected int Attack;
        protected int Defense;
        protected int Speed;
        protected Bitmap _image;

        public Bitmap getImage()
        {
            return _image;
        }

        public string getName() { return this.name; }
        
        public int getHP() { return this.HP; }
        
        public int getAttack() { return this.Attack; }
        
        public int getDefense() { return this.Defense; }

        public void takeDamage(int atk)
        {
            int damage;

            if(this.Defense > atk)
            {
                damage = 10;
            }
            else
            {
                damage = atk - this.Defense;
            }
            this.HP = this.HP - damage; 
        }
        public void getHp50()
        {
            HP = HP + 50;
        }
        public void getDef50()
        {
            Defense = Defense + 50;
        }

    }
}
