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
    public partial class Form3 : Form
    {
        private string[,] pokemon = new string[152, 8];
        private int[,] team = new int[6, 12];
        private int[,] teamOp = new int[6, 8];
        private string[,] moves = new String[4, 2];

        public Form3() { InitializeComponent(); }

        public void Pokemon(string[,] pass) { pokemon = pass; }

        public void Team(int[,] pass) { team = pass; }

        public void TeamOp(int[,] pass) { teamOp = pass; }

        public void Moves(string[,] pass) { moves = pass; }

        private void Form3_Load(object sender, EventArgs e)
        {
            txt1.Text = pokemon[team[0, 0], 0];
            txt2.Text = team[0, 1].ToString();
            txt3.Text = team[0, 2].ToString();
            txt4.Text = team[0, 3].ToString();
            txt5.Text = team[0, 4].ToString();
            txt6.Text = team[0, 5].ToString();
            txt7.Text = team[0, 6].ToString();
            txt8.Text = pokemon[team[1, 0], 0];
            txt9.Text = team[1, 1].ToString();
            txt10.Text = team[1, 2].ToString();
            txt11.Text = team[1, 3].ToString();
            txt12.Text = team[1, 4].ToString();
            txt13.Text = team[1, 5].ToString();
            txt14.Text = team[1, 6].ToString();
            txt15.Text = pokemon[team[2, 0], 0];
            txt16.Text = team[2, 1].ToString();
            txt17.Text = team[2, 2].ToString();
            txt18.Text = team[2, 3].ToString(); 
            txt19.Text = team[2, 4].ToString();
            txt20.Text = team[2, 5].ToString();
            txt21.Text = team[2, 6].ToString();
            txt22.Text = pokemon[team[3, 0], 0];
            txt23.Text = team[3, 1].ToString();
            txt24.Text = team[3, 2].ToString();
            txt25.Text = team[3, 3].ToString();
            txt26.Text = team[3, 4].ToString(); 
            txt27.Text = team[3, 5].ToString();
            txt28.Text = team[3, 6].ToString();
            txt29.Text = pokemon[team[4, 0], 0];
            txt30.Text = team[4, 1].ToString();
            txt31.Text = team[4, 2].ToString();
            txt32.Text = team[4, 3].ToString();
            txt33.Text = team[4, 4].ToString();
            txt34.Text = team[4, 5].ToString();
            txt35.Text = team[4, 6].ToString();
            txt36.Text = pokemon[team[5, 0], 0];
            txt37.Text = team[5, 1].ToString();
            txt38.Text = team[5, 2].ToString();
            txt39.Text = team[5, 3].ToString();
            txt40.Text = team[5, 4].ToString();
            txt41.Text = team[5, 5].ToString();
            txt42.Text = team[5, 6].ToString();
            textBox1.Text = pokemon[teamOp[0, 0],0];
            textBox2.Text = pokemon[teamOp[1, 0], 0];
            textBox3.Text = pokemon[teamOp[2, 0], 0];
            textBox4.Text = pokemon[teamOp[3, 0], 0];
            textBox5.Text = pokemon[teamOp[4, 0], 0];
            textBox6.Text = pokemon[teamOp[5, 0], 0];
            comboBox1.Text = "(choose)";
            comboBox2.Text = "(choose)";
            comboBox1.Items.Add(pokemon[team[0, 0], 0]);
            comboBox1.Items.Add(pokemon[team[1, 0], 0]);
            comboBox1.Items.Add(pokemon[team[2, 0], 0]);
            comboBox1.Items.Add(pokemon[team[3, 0], 0]);
            comboBox1.Items.Add(pokemon[team[4, 0], 0]);
            comboBox1.Items.Add(pokemon[team[5, 0], 0]);
            comboBox2.Items.Add(pokemon[teamOp[0, 0], 0]);
            comboBox2.Items.Add(pokemon[teamOp[1, 0], 0]);
            comboBox2.Items.Add(pokemon[teamOp[2, 0], 0]);
            comboBox2.Items.Add(pokemon[teamOp[3, 0], 0]);
            comboBox2.Items.Add(pokemon[teamOp[4, 0], 0]);
            comboBox2.Items.Add(pokemon[teamOp[5, 0], 0]);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "(choose)" && comboBox2.Text != "(choose)")
            {
                Form4 form4 = new Form4();
                form4.Pokemon(pokemon);
                form4.Team(team);
                form4.TeamOp(teamOp);
                form4.Moves(moves);
                if (comboBox1.Text == txt1.Text) { form4.Start1(comboBox1.Text, 0); }
                else if (comboBox1.Text == txt8.Text) { form4.Start1(comboBox1.Text, 1); }
                else if (comboBox1.Text == txt15.Text) { form4.Start1(comboBox1.Text, 2); }
                else if (comboBox1.Text == txt22.Text) { form4.Start1(comboBox1.Text, 3); }
                else if (comboBox1.Text == txt29.Text) { form4.Start1(comboBox1.Text, 4); }
                else if (comboBox1.Text == txt36.Text) { form4.Start1(comboBox1.Text, 5); }

                if (comboBox2.Text == textBox1.Text) { form4.Start2(comboBox2.Text, 0); }
                else if (comboBox2.Text == textBox2.Text) { form4.Start2(comboBox2.Text, 1); }
                else if (comboBox2.Text == textBox3.Text) { form4.Start2(comboBox2.Text, 2); }
                else if (comboBox2.Text == textBox4.Text) { form4.Start2(comboBox2.Text, 3); }
                else if (comboBox2.Text == textBox5.Text) { form4.Start2(comboBox2.Text, 4); }
                else if (comboBox2.Text == textBox6.Text) { form4.Start2(comboBox2.Text, 5); }
                form4.Show();
                this.Visible = false;
            }
        }
    }
}
