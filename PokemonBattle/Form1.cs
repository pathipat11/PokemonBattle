using PokemonBattle.pokemons;

namespace PokemonBattle
{
    public partial class Form1 : Form
    {
        List<Pokemon> pokemons;
        Pokemon selectedPokemon;
        Pokemon monster;
        public Form1()
        {
            InitializeComponent();

            pokemons = new List<Pokemon>();
            pokemons.Add(new Pichu());
            pokemons.Add(new Pikachu());
            pokemons.Add(new Froakie());
            pokemons.Add(new Greninja());

            this.monster = new Charizard();
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
            
            int damage = this.monster.getDefense() - this.selectedPokemon.getAttack();
            this.monster.takeDamage(damage);
            //this.tbHPMon.Text = damage.ToString();
            return this.

            //display data
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }

}