using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Char_Gen
{
    public partial class Form1 : Form
    {
        public Questions LinkQ;
        public static PlayerStats LinkStats;
        public Form1()
        {
            LinkStats = new PlayerStats();
            LinkQ = new Questions(this,LinkStats);
            InitializeComponent();
            LinkQ.Q1();
            
            button1.Enabled = false;
        }
        public int page = 1;//Page #
        bool test = false;//If the questions are done
        



        private void TurnOffButtons()
        {
            O1.Enabled = false;//Turns off buttons so they can't check multiple options
            O2.Enabled = false;
            O3.Enabled = false;
            O4.Enabled = false;
            O5.Enabled = false;
            O6.Enabled = false;
            button1.Enabled = true;
        }
        private void TurnOnButtons()
        {
            O1.Enabled = true;//Turns back on buttons so you can click them
            O2.Enabled = true;
            O3.Enabled = true;
            O4.Enabled = true;
            O5.Enabled = true;
            O6.Enabled = true;
            button1.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void WhenO1Q1Clicked(object sender, MouseEventArgs e)//When the option 1 is clicked
        {
            switch (page)
            {
                case 1://page 1 option 1
                    LinkStats.IncrementStat(StatIndex.Str);//if the page is 1 and option 1 is clicked then add 1 to these stats.
                    LinkStats.IncrementStat(StatIndex.Weapon);
                    break;
                case 2://page 2 option 1
                    LinkStats.IncrementStat(StatIndex.Con);
                    LinkStats.IncrementStat(StatIndex.Arm);
                    break;
                case 3://page 3 option 1
                    LinkStats.IncrementStat(StatIndex.Wis);
                    LinkStats.IncrementStat(StatIndex.Arm);
                    break;
                case 4://page 4 option 1
                    LinkStats.IncrementStat(StatIndex.Cha);
                    LinkStats.IncrementStat(StatIndex.Arm);
                    break;
                case 5://page 5 option 1
                    LinkStats.Setting = false;//Warpshell
                    break;
                case 6://page 6 option 1
                    if (LinkStats.Setting == true) { LinkStats.Race = "Elf"; }
                    else { LinkStats.Race = "Mecha"; }
                    break;
                
            }
            TurnOffButtons();
        }
        private void WhenO2Q1Clicked(object sender, MouseEventArgs e)//option 2
        {
            switch (page)
            {
                case 1://page 1 option 2
                    LinkStats.IncrementStat(StatIndex.Int);
                    LinkStats.IncrementStat(StatIndex.Magic);
                    break;
                case 2://page 2 option 2
                    LinkStats.IncrementStat(StatIndex.Dex);
                    LinkStats.IncrementStat(StatIndex.Arm);
                    break;
                case 3://page 3 option 2
                    LinkStats.IncrementStat(StatIndex.Dex);
                    LinkStats.IncrementStat(StatIndex.Basic);
                    break;
                case 4://page 4 option 2
                    LinkStats.IncrementStat(StatIndex.Str);
                    LinkStats.IncrementStat(StatIndex.Weapon);
                    break;
                case 5://page 5 option 2
                    LinkStats.Setting = true;//Alfheim
                    break;
                case 6://page 6 option 2
                    if (LinkStats.Setting == true) { LinkStats.Race = "Dwarf"; }
                    else { LinkStats.Race = "Reptoid"; }
                    break;
            }
            TurnOffButtons();
        }
        private void WhenO3Q1Clicked(object sender, MouseEventArgs e)
        {
            switch (page)
            {
                case 1://page 1 option 3
                    LinkStats.IncrementStat(StatIndex.Wis);
                    LinkStats.IncrementStat(StatIndex.Magic);
                    break;
                case 2://page 2 option 3
                    LinkStats.IncrementStat(StatIndex.Wis);
                    LinkStats.IncrementStat(StatIndex.Magic);
                    break;
                case 3://page 3 option 3
                    LinkStats.IncrementStat(StatIndex.Con);
                    LinkStats.IncrementStat(StatIndex.Arm);
                    break;
                case 4://page 4 option 3
                    LinkStats.IncrementStat(StatIndex.Wis);
                    LinkStats.IncrementStat(StatIndex.Arm);
                    break;
                case 6://page 5 option 3
                    if (LinkStats.Setting == true) { LinkStats.Race = "Small Folk"; }
                    else { LinkStats.Race = "Psyker"; }
                    break;
            }
            TurnOffButtons();
        }
        private void WhenO4Q1Clicked(object sender, MouseEventArgs e)
        {
            switch (page)
            {
                case 1://page 1 option 4
                    LinkStats.IncrementStat(StatIndex.Dex);
                    LinkStats.IncrementStat(StatIndex.Weapon);
                    break;
                case 2://page 2 option 4
                    LinkStats.IncrementStat(StatIndex.Str);
                    LinkStats.IncrementStat(StatIndex.Basic);
                    break;
                case 3://page 3 option 4
                    LinkStats.IncrementStat(StatIndex.Int);
                    LinkStats.IncrementStat(StatIndex.Basic);
                    break;
                case 4://page 4 option 4
                    LinkStats.IncrementStat(StatIndex.Int);
                    LinkStats.IncrementStat(StatIndex.Magic);
                    break;
                case 6://page 5 option 4
                    if (LinkStats.Setting == true) { LinkStats.Race = "Human"; }
                    else { LinkStats.Race = "Geno"; }
                    break;
            }
            TurnOffButtons();
        }

        private void WhenO5Q1Clicked(object sender, MouseEventArgs e)
        {
            switch (page)
            {
                case 1://page 1 option 5
                    LinkStats.IncrementStat(StatIndex.Con);
                    LinkStats.IncrementStat(StatIndex.Arm);
                    break;
                case 2://page 2 option 5
                    LinkStats.IncrementStat(StatIndex.Cha);
                    LinkStats.IncrementStat(StatIndex.Weapon);
                    break;
                case 3://page 3 option 5
                    LinkStats.IncrementStat(StatIndex.Str);
                    LinkStats.IncrementStat(StatIndex.Weapon);
                    break;
                case 4://page 4 option 5
                    LinkStats.IncrementStat(StatIndex.Con);
                    LinkStats.IncrementStat(StatIndex.Basic);
                    break;
                case 6://page 5 option 5
                    if (LinkStats.Setting == true) { LinkStats.Race = "Hill Folk"; }
                    else { LinkStats.Race = "Xill"; }
                    break;
            }
            TurnOffButtons();
        }

        private void WhenO6Q1Clicked(object sender, MouseEventArgs e)
        {
            switch (page)
            {
                case 1://page 1 option 6
                    LinkStats.IncrementStat(StatIndex.Cha);
                    LinkStats.IncrementStat(StatIndex.Arm);
                    break;
                case 2://page 2 option 6
                    LinkStats.IncrementStat(StatIndex.Int);
                    LinkStats.IncrementStat(StatIndex.Magic);
                    break;
                case 3://page 3 option 6
                    LinkStats.IncrementStat(StatIndex.Cha);
                    LinkStats.IncrementStat(StatIndex.Basic);
                    break;
                case 4://page 4 option 6
                    LinkStats.IncrementStat(StatIndex.Dex);
                    LinkStats.IncrementStat(StatIndex.Weapon);
                    break;
            }
            TurnOffButtons();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NextPage1(object sender, EventArgs e)
        {
            
            page ++;
            switch (page)
            {
                case 2:
                    LinkQ.Q2();//if page 2 then replace the text of question and options
                    break;
                case 3:
                    LinkQ.Q3();
                    break;
                case 4:
                    LinkQ.Q4();
                    break;
                case 5:
                    LinkQ.Q5();
                    O3.Visible = false;
                    O4.Visible = false; 
                    O5.Visible = false;
                    O6.Visible = false;
                    break;
                case 6:
                    LinkQ.Q6();
                    O3.Visible = true;
                    O4.Visible = true;
                    O5.Visible = true;
                    break;
                case 7:
                    this.Hide();
                    LinkStats.Results();
                    Character_Sheet Fin = new Character_Sheet(this, LinkStats);
                    Fin.Show();
                    
                    break;
            }
            O1.Checked = false;//Unchecks all options
            O2.Checked = false;
            O3.Checked = false;
            O3.Checked = false;
            O4.Checked = false;
            O5.Checked = false;
            O6.Checked = false;
            TurnOnButtons();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Question_Click(object sender, EventArgs e)
        {

        }

        private void O1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
