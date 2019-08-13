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
    public partial class Form4 : Form
    {
        private string[,] pokemon = new string[152, 8];
        private int[,] team = new int[6, 12];
        private int[,] teamOp = new int[6, 8];
        private string[,] moves = new String[4, 4];
        private string start1;
        private string start2;
        public int position1;
        private int position2;

        public Form4() { InitializeComponent(); }

        public void Pokemon(string[,] pass) { pokemon = pass; }

        public void Team(int[,] pass) { team = pass; }

        public void TeamOp(int[,] pass) { teamOp = pass; }

        public void Moves(string[,] pass) { moves = pass; }

        public void Start1(string pass, int passL) { start1 = pass; position1 = passL; }

        public void Start2(string pass, int passL) { start2 = pass; position2 = passL; }

        private void Form4_Load(object sender, EventArgs e)
        {

            textBox1.Text = start1;
            textBox14.Text = start2;
            textBox14.ReadOnly = true;
            label19.Text = pokemon[team[position1, 0], 7];
            label21.Text = pokemon[teamOp[position2, 0], 7];

            comboBox3.Text = "Healthy";
            comboBox4.Text = "Healthy";

            //pokemon stats
            textBox2.Text = team[position1, 1].ToString();
            textBox3.Text = team[position1, 2].ToString();
            textBox4.Text = team[position1, 3].ToString();
            textBox5.Text = team[position1, 4].ToString();
            textBox6.Text = team[position1, 5].ToString();
            textBox7.Text = team[position1, 6].ToString();
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;

            radioButton1.Text = moves[team[position1, 8], 0];
            radioButton2.Text = moves[team[position1, 9], 0];
            radioButton3.Text = moves[team[position1, 10], 0];
            radioButton4.Text = moves[team[position1, 11], 0];
            //enemy pokemon stats
            textBox8.Text = teamOp[position2, 1].ToString();
            textBox9.Text = teamOp[position2, 2].ToString();
            textBox10.Text = teamOp[position2, 3].ToString();
            textBox11.Text = teamOp[position2, 4].ToString();
            textBox12.Text = teamOp[position2, 5].ToString();
            textBox13.Text = teamOp[position2, 6].ToString();
            textBox27.Text = teamOp[position2, 1].ToString();
            textBox28.Text = teamOp[position2, 2].ToString();
            textBox29.Text = teamOp[position2, 3].ToString();
            textBox30.Text = teamOp[position2, 4].ToString();
            textBox31.Text = teamOp[position2, 5].ToString();
            textBox32.Text = teamOp[position2, 6].ToString();
            textBox8.ReadOnly = true;
            textBox9.ReadOnly = true;
            textBox10.ReadOnly = true;
            textBox11.ReadOnly = true;
            textBox12.ReadOnly = true;
            textBox13.ReadOnly = true;

            //enemy stats modifying
            textBox17.Text = "0"; textBox18.Text = "0"; textBox19.Text = "0"; textBox20.Text = "0"; textBox21.Text = "0";
            textBox15.Text = "0"; textBox22.Text = "0"; textBox23.Text = "0"; textBox24.Text = "0"; textBox25.Text = "0";
            textBox26.Text = "0"; textBox16.Text = "0"; 
            textBox17.TextChanged += new System.EventHandler(this.HPchanged);
            textBox15.TextChanged += new System.EventHandler(this.HPchanged);
            textBox16.TextChanged += new System.EventHandler(this.ATKchanged);
            textBox18.TextChanged += new System.EventHandler(this.ATKchanged);
            textBox23.TextChanged += new System.EventHandler(this.DEFchanged);
            textBox19.TextChanged += new System.EventHandler(this.DEFchanged);
            textBox24.TextChanged += new System.EventHandler(this.SPATKchanged);
            textBox20.TextChanged += new System.EventHandler(this.SPATKchanged);
            textBox25.TextChanged += new System.EventHandler(this.SPDEFchanged);
            textBox21.TextChanged += new System.EventHandler(this.SPDEFchanged);
            textBox26.TextChanged += new System.EventHandler(this.SPDchanged);
            textBox22.TextChanged += new System.EventHandler(this.SPDchanged);
            textBox27.ReadOnly = true;
            textBox28.ReadOnly = true;
            textBox29.ReadOnly = true;
            textBox30.ReadOnly = true;
            textBox31.ReadOnly = true;
            textBox32.ReadOnly = true;

            

            for (int i = 0; i < 4; i++) {
                comboBox1.Items.Add(moves[i, 0]);
                comboBox2.Items.Add(moves[i, 0]);
                comboBox5.Items.Add(moves[i, 0]);
                comboBox6.Items.Add(moves[i, 0]);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HPchanged(object sender, EventArgs e)
        {
            int enemyHp = (int.Parse(textBox8.Text) + int.Parse(textBox15.Text) + (int.Parse(textBox17.Text) / 4));
            textBox27.Text = enemyHp.ToString();
        }

        private void ATKchanged(object sender, EventArgs e)
        {
            int enemyAtk = (int.Parse(textBox9.Text) + int.Parse(textBox16.Text) + (int.Parse(textBox18.Text) / 4));
            textBox28.Text = enemyAtk.ToString();
        }

        private void DEFchanged(object sender, EventArgs e)
        {
            int enemyDef = (int.Parse(textBox10.Text) + int.Parse(textBox23.Text) + (int.Parse(textBox19.Text) / 4));
            textBox29.Text = enemyDef.ToString();
        }

        private void SPATKchanged(object sender, EventArgs e)
        {
            int enemySpatk = (int.Parse(textBox11.Text) + int.Parse(textBox24.Text) + (int.Parse(textBox20.Text) / 4));
            textBox30.Text = enemySpatk.ToString();
        }

        private void SPDEFchanged(object sender, EventArgs e)
        {
            int enemySpdef = (int.Parse(textBox12.Text) + int.Parse(textBox25.Text) + (int.Parse(textBox21.Text) / 4));
            textBox31.Text = enemySpdef.ToString();
        }

        private void SPDchanged(object sender, EventArgs e)
        {
            int enemySpd = (int.Parse(textBox13.Text) + int.Parse(textBox26.Text) + (int.Parse(textBox22.Text) / 4));
            textBox32.Text = enemySpd.ToString();
        }

        public void Switch(int position)
        {
            position1 = position;
            textBox1.Text = pokemon[team[position1, 0], 0];
            label19.Text = pokemon[team[position1, 0], 7];
            textBox2.Text = team[position1, 1].ToString();
            textBox3.Text = team[position1, 2].ToString();
            textBox4.Text = team[position1, 3].ToString();
            textBox5.Text = team[position1, 4].ToString();
            textBox6.Text = team[position1, 5].ToString();
            textBox7.Text = team[position1, 6].ToString();
            radioButton1.Text = moves[team[position1, 8], 0];
            radioButton2.Text = moves[team[position1, 9], 0];
            radioButton3.Text = moves[team[position1, 10], 0];
            radioButton4.Text = moves[team[position1, 11], 0];
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int movePosition = 0;
            String moveName = "blaster";
            int moveDMG = 0;
            double realDMG1 = 0;
            double realDMG2 = 0;
            double modifier = 0;
            int dmgType = 0;
            double stab = 1;
            int enemyDef = int.Parse(textBox29.Text);
            int enemySpdef = int.Parse(textBox31.Text);
            Boolean move = false;

            int enemyMovePosition = 0;
            String enemyMoveName = "blaster";
            int enemyMoveDMG = 0;
            double enemyRealDMG1 = 0;
            double enemyRealDMG2 = 0;
            double enemyModifier = 0;
            int enemyDmgType = 0;
            double enemyStab = 1;
            int def = int.Parse(textBox4.Text);
            int spdef = int.Parse(textBox6.Text);
            Boolean enemyMove = false;

            if (radioButton5.Checked == true)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (comboBox1.Text == moves[i, 0])
                    {
                        enemyMove = true;
                        enemyMovePosition = i;
                        enemyMoveName = moves[i, 0];
                        enemyMoveDMG = int.Parse(moves[i, 1]);
                        enemyDmgType = int.Parse(moves[i, 2]);
                        if (pokemon[teamOp[position2, 0], 7].Contains(moves[i, 3]))
                            stab = 1.5;

                    }
                }
            }

            if (radioButton6.Checked == true)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (comboBox2.Text == moves[i, 0])
                    {
                        enemyMove = true;
                        enemyMovePosition = i;
                        enemyMoveName = moves[i, 0];
                        enemyMoveDMG = int.Parse(moves[i, 1]);
                        enemyDmgType = int.Parse(moves[i, 2]);
                        if (pokemon[teamOp[position2, 0], 7].Contains(moves[i, 3]))
                            stab = 1.5;

                    }
                }
            }

            if (radioButton7.Checked == true)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (comboBox5.Text == moves[i, 0])
                    {
                        enemyMove = true;
                        enemyMovePosition = i;
                        enemyMoveName = moves[i, 0];
                        enemyMoveDMG = int.Parse(moves[i, 1]);
                        enemyDmgType = int.Parse(moves[i, 2]);
                        if (pokemon[teamOp[position2, 0], 7].Contains(moves[i, 3]))
                            stab = 1.5;

                    }
                }
            }

            if (radioButton8.Checked == true)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (comboBox6.Text == moves[i, 0])
                    {
                        enemyMove = true;
                        enemyMovePosition = i;
                        enemyMoveName = moves[i, 0];
                        enemyMoveDMG = int.Parse(moves[i, 1]);
                        enemyDmgType = int.Parse(moves[i, 2]);
                        if (pokemon[teamOp[position2, 0], 7].Contains(moves[i, 3]))
                            stab = 1.5;

                    }
                }
            }

            if (radioButton1.Checked == true)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (radioButton1.Text == moves[i, 0])
                    {
                        move = true;
                        movePosition = i;
                        moveName = moves[i, 0];
                        moveDMG = int.Parse(moves[i, 1]);
                        dmgType = int.Parse(moves[i, 2]);
                        if (pokemon[team[position1, 0], 7].Contains(moves[i, 3]))
                            stab = 1.5;

                    }
                }
            }
            if (radioButton2.Checked == true)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (radioButton2.Text == moves[i, 0])
                        {
                            move = true;
                            movePosition = i;
                            moveName = moves[i, 0];
                            moveDMG = int.Parse(moves[i, 1]);
                            dmgType = int.Parse(moves[i, 2]);
                            if (pokemon[team[position1, 0], 7].Contains(moves[i, 3]))
                                stab = 1.5;

                        }
                    }
                }
            if (radioButton3.Checked == true)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (radioButton3.Text == moves[i, 0])
                    {
                        move = true;
                        movePosition = i;
                        moveName = moves[i, 0];
                        moveDMG = int.Parse(moves[i, 1]);
                        dmgType = int.Parse(moves[i, 2]);
                        if (pokemon[team[position1, 0], 7].Contains(moves[i, 3]))
                            stab = 1.5;

                    }
                }
            }
            if (radioButton4.Checked == true)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (radioButton4.Text == moves[i, 0])
                    {
                        move = true;
                        movePosition = i;
                        moveName = moves[i, 0];
                        moveDMG = int.Parse(moves[i, 1]);
                        dmgType = int.Parse(moves[i, 2]);
                        if (pokemon[team[position1, 0], 7].Contains(moves[i, 3]))
                            stab = 1.5;

                    }
                }
            }
            if (move)
            {
               
                
                    modifier = 1 * 1 * 1 * 1 * stab * 1;
                    if (dmgType == 0)
                    {
                        realDMG1 = ((2 * 50 / 5.0 + 2) * moveDMG * team[position1, 2] / enemyDef / 50 + 2) * modifier * 0.85;
                        realDMG2 = ((2 * 50 / 5.0 + 2) * moveDMG * team[position1, 2] / enemyDef / 50 + 2) * modifier * 1;
                    }

                    if (dmgType == 1)
                    {
                        realDMG1 = ((2 * 50 / 5.0 + 2) * moveDMG * team[position1, 4] / enemySpdef / 50 + 2) * modifier * 0.85;
                        realDMG2 = ((2 * 50 / 5.0 + 2) * moveDMG * team[position1, 4] / enemySpdef / 50 + 2) * modifier * 1;
                    }
                
            }

            if (enemyMove)
            {

                {
                    enemyModifier = 1 * 1 * 1 * 1 * enemyStab * 1;
                    if (enemyDmgType == 0)
                    {
                        enemyRealDMG1 = ((2 * 50 / 5.0 + 2) * enemyMoveDMG * teamOp[position2, 2] / def / 50 + 2) * enemyModifier * 0.85;
                        enemyRealDMG2 = ((2 * 50 / 5.0 + 2) * enemyMoveDMG * teamOp[position2, 2] / def / 50 + 2) * enemyModifier * 1;
                    }

                    if (enemyDmgType == 1)
                    {
                        enemyRealDMG1 = ((2 * 50 / 5.0 + 2) * enemyMoveDMG * teamOp[position1, 4] / spdef / 50 + 2) * enemyModifier * 0.85;
                        enemyRealDMG2 = ((2 * 50 / 5.0 + 2) * enemyMoveDMG * teamOp[position1, 4] / spdef / 50 + 2) * enemyModifier * 1;
                    }


                }
            }

            if (move && enemyMove)
            {
                MessageBox.Show(moveName + " will deal between " + realDMG1 + " and " + realDMG2 + " to the opponent." + Environment.NewLine +
                    enemyMoveName + " will deal between " + enemyRealDMG1 + " and " + enemyRealDMG2 + " to the your pokémon.");
            }
            else if(move && !enemyMove)
            {
                MessageBox.Show(moveName + " will deal between " + realDMG1 + " and " + realDMG2 + " to the opponent." + Environment.NewLine +
                    "No enemy move selected.");
            }
            else if(!move && enemyMove)
            {
                MessageBox.Show("No move selected." + Environment.NewLine +
                   enemyMoveName + " will deal between " + enemyRealDMG1 + " and " + enemyRealDMG2 + " to the your pokémon.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(this);
            form5.Team(team);
            form5.Position(position1);
            form5.Pokemon(pokemon);
            form5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}