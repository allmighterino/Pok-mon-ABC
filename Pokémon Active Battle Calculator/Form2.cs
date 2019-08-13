using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokémon_Active_Battle_Calculator
{
    public partial class Form2 : Form
    {
        private string[,] pokemon = new string[151, 8];
        private int[,] team = new int[6, 12];
        private int[,] teamOp = new int[6, 8];
        private string[,] moves = new String[4, 4];

        public Form2() { InitializeComponent(); }
        
        public void Pokemon(string[,] pass) { pokemon = pass; }

        public void Team(int[,] pass) { team = pass; }

        public void Moves(string[,] pass) { moves = pass; }

        private void Form2_Load(object sender, EventArgs e)
            
        {
            for (int i = 0; i < 152; i++) {
                comboBox1.Items.Add(pokemon[i, 0]);
                comboBox2.Items.Add(pokemon[i, 0]);
                comboBox3.Items.Add(pokemon[i, 0]);
                comboBox4.Items.Add(pokemon[i, 0]);
                comboBox5.Items.Add(pokemon[i, 0]);
                comboBox6.Items.Add(pokemon[i, 0]);
            
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int slot = 0;

            for(int i = 0; i < 152; i++)
            {
                if (comboBox1.Text == pokemon[i, 0] && slot == 0)
                {
                    teamOp[0, 0] = i;
                    teamOp[0, 1] = int.Parse(pokemon[i, 1]);
                    teamOp[0, 2] = int.Parse(pokemon[i, 2]);
                    teamOp[0, 3] = int.Parse(pokemon[i, 3]);
                    teamOp[0, 4] = int.Parse(pokemon[i, 4]);
                    teamOp[0, 5] = int.Parse(pokemon[i, 5]);
                    teamOp[0, 6] = int.Parse(pokemon[i, 6]);
                    teamOp[0, 7] = i;
                    slot++;
                    i = 0;
                }

                if (comboBox2.Text == pokemon[i, 0] && slot == 1)
                {
                    teamOp[1, 0] = i;
                    teamOp[1, 1] = int.Parse(pokemon[i, 1]);
                    teamOp[1, 2] = int.Parse(pokemon[i, 2]);
                    teamOp[1, 3] = int.Parse(pokemon[i, 3]);
                    teamOp[1, 4] = int.Parse(pokemon[i, 4]);
                    teamOp[1, 5] = int.Parse(pokemon[i, 5]);
                    teamOp[1, 6] = int.Parse(pokemon[i, 6]);
                    teamOp[1, 7] = i;
                    slot++;
                    i = 0;
                }

                if (comboBox3.Text == pokemon[i, 0] && slot == 2)
                {
                    teamOp[2, 0] = i;
                    teamOp[2, 1] = int.Parse(pokemon[i, 1]);
                    teamOp[2, 2] = int.Parse(pokemon[i, 2]);
                    teamOp[2, 3] = int.Parse(pokemon[i, 3]);
                    teamOp[2, 4] = int.Parse(pokemon[i, 4]);
                    teamOp[2, 5] = int.Parse(pokemon[i, 5]);
                    teamOp[2, 6] = int.Parse(pokemon[i, 6]);
                    teamOp[2, 7] = i;
                    slot++;
                    i = 0;
                }

                if (comboBox4.Text == pokemon[i, 0] && slot == 3)
                {
                    teamOp[3, 0] = i;
                    teamOp[3, 1] = int.Parse(pokemon[i, 1]);
                    teamOp[3, 2] = int.Parse(pokemon[i, 2]);
                    teamOp[3, 3] = int.Parse(pokemon[i, 3]);
                    teamOp[3, 4] = int.Parse(pokemon[i, 4]);
                    teamOp[3, 5] = int.Parse(pokemon[i, 5]);
                    teamOp[3, 6] = int.Parse(pokemon[i, 6]);
                    teamOp[3, 7] = i;
                    slot++;
                    i = 0;
                }

                if (comboBox5.Text == pokemon[i, 0] && slot == 4)
                {
                    teamOp[4, 0] = i;
                    teamOp[4, 1] = int.Parse(pokemon[i, 1]);
                    teamOp[4, 2] = int.Parse(pokemon[i, 2]);
                    teamOp[4, 3] = int.Parse(pokemon[i, 3]);
                    teamOp[4, 4] = int.Parse(pokemon[i, 4]);
                    teamOp[4, 5] = int.Parse(pokemon[i, 5]);
                    teamOp[4, 6] = int.Parse(pokemon[i, 6]);
                    teamOp[4, 7] = i;
                    slot++;
                    i = 0;
                }

                if (comboBox6.Text == pokemon[i, 0] && slot == 5)
                {
                    teamOp[5, 0] = i;
                    teamOp[5, 1] = int.Parse(pokemon[i, 1]);
                    teamOp[5, 2] = int.Parse(pokemon[i, 2]);
                    teamOp[5, 3] = int.Parse(pokemon[i, 3]);
                    teamOp[5, 4] = int.Parse(pokemon[i, 4]);
                    teamOp[5, 5] = int.Parse(pokemon[i, 5]);
                    teamOp[5, 6] = int.Parse(pokemon[i, 6]);
                    teamOp[5, 7] = i;
                }

            }

            Form3 form3 = new Form3();
            form3.Pokemon(pokemon);
            form3.Team(team);
            form3.TeamOp(teamOp);
            form3.Moves(moves);
            form3.Show();
            this.Visible = false;

        }
    }
}