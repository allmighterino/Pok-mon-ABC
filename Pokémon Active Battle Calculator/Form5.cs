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
    public partial class Form5 : Form
    {
        private string[,] pokemon = new string[152, 8];
        private int[,] team = new int[6, 12];
        private int position1;
        private Form4 form4;

        public void Team(int[,] pass) { team = pass; }
        public void Position(int pass) { position1 = pass; }
        public void Pokemon(string[,] pass) { pokemon = pass; }
        
        public Form5(Form4 f)
        {
            InitializeComponent();
            form4 = f;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            int slot = 0;
            for(int i = 0; i < 6; i++)
            {
                if (i != position1 && slot == 0)
                {
                    radioButton1.Text = pokemon[team[i, 0], 0]; slot++;
                }
                else if (i != position1 && slot == 1)
                {
                    radioButton2.Text = pokemon[team[i, 0], 0]; slot++;
                }
                else if (i != position1 && slot == 2)
                {
                    radioButton3.Text = pokemon[team[i, 0], 0]; slot++;
                }
                else if (i != position1 && slot == 3)
                {
                    radioButton4.Text = pokemon[team[i, 0], 0]; slot++;
                }

                else if (i != position1 && slot == 4)
                {
                    radioButton5.Text = pokemon[team[i, 0], 0]; slot++;
                }


}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                for (int i = 0; i < 6; i++) {
                    if (radioButton1.Text == pokemon[team[i, 0], 0]){
                        form4.Switch(i);
                        this.Close();
                    }
                   }
            }
            if (radioButton2.Checked == true)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (radioButton2.Text == pokemon[team[i, 0], 0])
                    {
                        form4.Switch(i);
                        this.Close();
                    }
                }
            }
            if (radioButton3.Checked == true)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (radioButton3.Text == pokemon[team[i, 0], 0])
                    {
                        form4.Switch(i);
                        this.Close();
                    }
                }
            }
            if (radioButton4.Checked == true)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (radioButton4.Text == pokemon[team[i, 0], 0])
                    {
                        form4.Switch(i);
                        this.Close();
                    }
                }
            }
            if (radioButton5.Checked == true)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (radioButton5.Text == pokemon[team[i, 0], 0])
                    {
                        form4.Switch(i);
                        this.Close();
                    }
                }
            }

        }
    }
}
