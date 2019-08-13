using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pokémon_Active_Battle_Calculator
{
    public partial class Form1 : Form
    {
        private string[,] pokemon = new String[152, 8];
        private int[,] team = new int[6, 12];
        private string[,] moves = new String[4, 4];

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                StreamReader sr = new StreamReader(@"C:\Users\Usuario\Desktop\jt\POKEMON ABC\names1.txt");
                String line = sr.ReadLine();
                int lineArray = 0;
                int column = 0;
                Boolean stats = false;
                while (line != null)
                {
                    pokemon[lineArray, column] = line;
                    if (stats == false)
                    {
                        comboBox1.Items.Add(pokemon[lineArray, column]);
                        comboBox2.Items.Add(pokemon[lineArray, column]);
                        comboBox3.Items.Add(pokemon[lineArray, column]);
                        comboBox4.Items.Add(pokemon[lineArray, column]);
                        comboBox5.Items.Add(pokemon[lineArray, column]);
                        comboBox6.Items.Add(pokemon[lineArray, column]);
                    }
                    lineArray++;
                    line = sr.ReadLine();
                    if (lineArray == 152 && column == 6)
                    {
                        column = 7;
                        lineArray = 0;
                    }
                    if (lineArray == 152 && column == 5)
                    {
                        column = 6;
                        lineArray = 0;
                    }
                    if (lineArray == 152 && column == 4)
                    {
                        column = 5;
                        lineArray = 0;
                    }
                    if (lineArray == 152 && column == 3)
                    {
                        column = 4;
                        lineArray = 0;
                    }
                    if (lineArray == 152 && column == 2)
                    {
                        column = 3;
                        lineArray = 0;
                    }
                    if (lineArray == 152 && column == 1)
                    {
                        column = 2;
                        lineArray = 0;
                    }
                    if (lineArray == 152 && column == 0)
                    {
                        column = 1;
                        lineArray = 0;
                        stats = true;
                    }

                }

                foreach (Control iv in Controls)
                {
                    if (iv is TextBox)
                    {
                        iv.Text = "0";
                    }

                }

                StreamReader sr2 = new StreamReader(@"C:\Users\Usuario\Desktop\jt\POKEMON ABC\moves.txt");
                line = sr2.ReadLine();
                lineArray = 0;
                column = 0;

                while (line != null)
                {
                    moves[lineArray, column] = line;
                    if (column == 0)
                    {
                        comboBox7.Items.Add(moves[lineArray, column]); comboBox19.Items.Add(moves[lineArray, column]);
                        comboBox8.Items.Add(moves[lineArray, column]); comboBox20.Items.Add(moves[lineArray, column]);
                        comboBox9.Items.Add(moves[lineArray, column]); comboBox21.Items.Add(moves[lineArray, column]);
                        comboBox10.Items.Add(moves[lineArray, column]); comboBox22.Items.Add(moves[lineArray, column]);
                        comboBox11.Items.Add(moves[lineArray, column]); comboBox23.Items.Add(moves[lineArray, column]);
                        comboBox12.Items.Add(moves[lineArray, column]); comboBox24.Items.Add(moves[lineArray, column]);
                        comboBox13.Items.Add(moves[lineArray, column]); comboBox25.Items.Add(moves[lineArray, column]);
                        comboBox14.Items.Add(moves[lineArray, column]); comboBox26.Items.Add(moves[lineArray, column]);
                        comboBox15.Items.Add(moves[lineArray, column]); comboBox27.Items.Add(moves[lineArray, column]);
                        comboBox16.Items.Add(moves[lineArray, column]); comboBox28.Items.Add(moves[lineArray, column]);
                        comboBox17.Items.Add(moves[lineArray, column]); comboBox29.Items.Add(moves[lineArray, column]);
                        comboBox18.Items.Add(moves[lineArray, column]); comboBox30.Items.Add(moves[lineArray, column]);
                       
                    }

                    lineArray++;

                    if (lineArray == 4)
                    {
                        column++;
                        lineArray = 0;
                    }
                    
                    line = sr2.ReadLine();
                }



            }



            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {


                for (int i = 0; i < 152; i++)
                {
                    if (comboBox1.Text == (pokemon[i, 0]))
                    {
                        team[0, 0] = i;
                        team[0, 1] = int.Parse(textBox1.Text);
                        team[0, 2] = int.Parse(textBox2.Text);
                        team[0, 3] = int.Parse(textBox3.Text);
                        team[0, 4] = int.Parse(textBox4.Text);
                        team[0, 5] = int.Parse(textBox5.Text);
                        team[0, 6] = int.Parse(textBox6.Text);
                        team[0, 7] = i;
                    }
                }
           

            for (int i = 0; i < 152; i++)
            {
                if (comboBox2.Text == (pokemon[i, 0]))
                {
                    team[1, 0] = i;
                    team[1, 1] = int.Parse(textBox13.Text);
                    team[1, 2] = int.Parse(textBox14.Text);
                    team[1, 3] = int.Parse(textBox15.Text);
                    team[1, 4] = int.Parse(textBox16.Text);
                    team[1, 5] = int.Parse(textBox17.Text);
                    team[1, 6] = int.Parse(textBox18.Text);
                    team[1, 7] = i;
                }
            }

            for (int i = 0; i < 152; i++)
            {
                if (comboBox3.Text == (pokemon[i, 0]))
                {
                    team[2, 0] = i;
                    team[2, 1] = int.Parse(textBox25.Text);
                    team[2, 2] = int.Parse(textBox26.Text);
                    team[2, 3] = int.Parse(textBox27.Text);
                    team[2, 4] = int.Parse(textBox28.Text);
                    team[2, 5] = int.Parse(textBox29.Text);
                    team[2, 6] = int.Parse(textBox30.Text);
                    team[2, 7] = i;
                }
            }

            for (int i = 0; i < 152; i++)
            {
                if (comboBox4.Text == (pokemon[i, 0]))
                {
                    team[3, 0] = i;
                    team[3, 1] = int.Parse(textBox37.Text);
                    team[3, 2] = int.Parse(textBox38.Text);
                    team[3, 3] = int.Parse(textBox39.Text);
                    team[3, 4] = int.Parse(textBox40.Text);
                    team[3, 5] = int.Parse(textBox41.Text);
                    team[3, 6] = int.Parse(textBox42.Text);
                    team[3, 7] = i;
                }
            }

            for (int i = 0; i < 152; i++)
            {
                if (comboBox5.Text == (pokemon[i, 0]))
                {
                    team[4, 0] = i;
                    team[4, 1] = int.Parse(textBox49.Text);
                    team[4, 2] = int.Parse(textBox50.Text);
                    team[4, 3] = int.Parse(textBox51.Text);
                    team[4, 4] = int.Parse(textBox52.Text);
                    team[4, 5] = int.Parse(textBox53.Text);
                    team[4, 6] = int.Parse(textBox54.Text);
                    team[4, 7] = i;
                }
            }

            for (int i = 0; i < 152; i++)
            {
                if (comboBox6.Text == (pokemon[i, 0]))
                {
                    team[5, 0] = i;
                    team[5, 1] = int.Parse(textBox61.Text);
                    team[5, 2] = int.Parse(textBox62.Text);
                    team[5, 3] = int.Parse(textBox63.Text);
                    team[5, 4] = int.Parse(textBox64.Text);
                    team[5, 5] = int.Parse(textBox65.Text);
                    team[5, 6] = int.Parse(textBox66.Text);
                    team[5, 7] = i;
                }
            }

            for(int i = 0; i < 4; i++)
            {
                if (comboBox7.Text == moves[i, 0]) team[0, 8] = i;
                if (comboBox8.Text == moves[i, 0]) team[0, 9] = i;
                if (comboBox9.Text == moves[i, 0]) team[0, 10] = i;
                if (comboBox10.Text == moves[i, 0]) team[0, 11] = i;
                if (comboBox11.Text == moves[i, 0]) team[1, 8] = i;
                if (comboBox12.Text == moves[i, 0]) team[1, 9] = i;
                if (comboBox13.Text == moves[i, 0]) team[1, 10] = i;
                if (comboBox14.Text == moves[i, 0]) team[1, 11] = i;
                if (comboBox15.Text == moves[i, 0]) team[2, 8] = i;
                if (comboBox16.Text == moves[i, 0]) team[2, 9] = i;
                if (comboBox17.Text == moves[i, 0]) team[2, 10] = i;
                if (comboBox18.Text == moves[i, 0]) team[2, 11] = i;
                if (comboBox19.Text == moves[i, 0]) team[3, 8] = i;
                if (comboBox20.Text == moves[i, 0]) team[3, 9] = i;
                if (comboBox21.Text == moves[i, 0]) team[3, 10] = i;
                if (comboBox22.Text == moves[i, 0]) team[3, 11] = i;
                if (comboBox23.Text == moves[i, 0]) team[4, 8] = i;
                if (comboBox24.Text == moves[i, 0]) team[4, 9] = i;
                if (comboBox25.Text == moves[i, 0]) team[4, 10] = i;
                if (comboBox26.Text == moves[i, 0]) team[4, 11] = i;
                if (comboBox27.Text == moves[i, 0]) team[5, 8] = i;
                if (comboBox28.Text == moves[i, 0]) team[5, 9] = i;
                if (comboBox29.Text == moves[i, 0]) team[5, 10] = i;
                if (comboBox30.Text == moves[i, 0]) team[5, 11] = i;
            }

            Form2 form2 = new Form2();
                    form2.Pokemon(pokemon);
                    form2.Team(team);
                    form2.Moves(moves);
                    form2.Show();
                    this.Visible = false;
                
            
        }

        private void label32_Click(object sender, EventArgs e)
        {
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}