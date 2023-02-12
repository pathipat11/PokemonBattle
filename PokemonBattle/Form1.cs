using PokemonBattle.pokemons;

namespace PokemonBattle
{
    public partial class Form1 : Form
    {
        List<Pokemon> pokemons;
        Pokemon selectedPokemon;
        Pokemon monster;

        // count hit 
        int hit = 1;
        // item
        int itemHp = 5;
        int itemDef = 2;
        //charactor
        int Pic = 1;
        int Pika = 1;
        int Fro = 1;
        int Gern = 1;

        public Form1()
        {
            InitializeComponent();

            pokemons = new List<Pokemon>();
            pokemons.Add(new Pichu());
            pokemons.Add(new Pikachu());
            pokemons.Add(new Froakie());
            pokemons.Add(new Greninja());

            this.monster = new Mewtwo();
            this.pictureBox2.Image = this.monster.getImage();
            this.tbNameMon.Text = this.monster.getName();
            this.tbHPMon.Text = this.monster.getHP().ToString();

        }

        //Pichu
        private void button1_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[0];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            this.tbHP.Text = selectedPokemon.getHP().ToString();
        }

        //Pikachu
        private void button2_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[1];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            this.tbHP.Text = selectedPokemon.getHP().ToString();

        }

        //Froakie
        private void button3_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[2];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            this.tbHP.Text = selectedPokemon.getHP().ToString();
        }

        //Greninja
        private void button4_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[3];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            this.tbHP.Text = selectedPokemon.getHP().ToString();
        }

        //Attack
        private void Attack_Click(object sender, EventArgs e)
        {
            var pokePlayer = selectedPokemon;
            var pokeMonster = monster;

            int damage = Math.Abs(this.monster.getDefense() - this.selectedPokemon.getAttack());
            this.monster.takeDamage(damage);
            this.tbHPMon.Text = monster.getHP().ToString();

            // player hit 3 / monster hit 1
            if ((hit % 3) == 0)
            {
                var monster = Math.Abs(this.selectedPokemon.getDefense() - this.monster.getAttack());
                this.selectedPokemon.takeDamage(monster);
                this.tbHP.Text = this.selectedPokemon.getHP().ToString();
            }
            hit++;

            if (pokemons[0].getHP() <= 0)
            {
                MessageBox.Show("Pokemon has died, please replace it with a new one.");
                Pichu.Enabled = false;


            }
            if (pokemons[1].getHP() <= 0)
            {
                MessageBox.Show("Pokemon has died, please replace it with a new one.");
                Pikachu.Enabled = false;

            }
            if (pokemons[2].getHP() <= 0)
            {
                MessageBox.Show("Pokemon has died, please replace it with a new one.");
                Froakie.Enabled = false;
                
            }
            if (pokemons[3].getHP() <= 0)
            {
                MessageBox.Show("Pokemon has died, please replace it with a new one.");
                Greninja.Enabled = false;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.selectedPokemon.getHp50();
            this.tbHP.Text = this.selectedPokemon.getHP().ToString();
            itemHp--;
            if (itemHp == 0)
            {
                btnPlusHP50.Enabled = false;
                MessageBox.Show("item emtry");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.selectedPokemon.getDef50();
            this.selectedPokemon.getDefense().ToString();
            itemDef--;
            if (itemDef == 0)
            {
                btnDefHP50.Enabled = false;
                MessageBox.Show("item emtry");
            }
        }
    }

}