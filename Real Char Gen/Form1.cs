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
        public PlayerStats LinkStats;
        public Form1()
        {
            LinkQ = new Questions(this);
            InitializeComponent();
            LinkQ.Q1();
            LinkStats = new PlayerStats();
        }
        public int page = 1;//Page #
        bool test = false;//If the questions are done
        String Class;
        
        
        
        private void TurnOffButtons()
        {
            O1.Enabled = false;//Turns off buttons so they can't check multiple options
            O2.Enabled = false;
            O3.Enabled = false;
            O3.Enabled = false;
            O4.Enabled = false;
            O5.Enabled = false;
            O6.Enabled = false;
        }
        private void TurnOnButtons()
        {
            O1.Enabled = true;//Turns back on buttons so you can click them
            O2.Enabled = true;
            O3.Enabled = true;
            O3.Enabled = true;
            O4.Enabled = true;
            O5.Enabled = true;
            O6.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void WhenO1Q1Clicked(object sender, MouseEventArgs e)//When the option is clicked
        {
            switch (page)
            {
                case 1:
                    LinkStats.IncrementStat(StatIndex.Str);//if the page is 1 and option 1 is clicked then add 1 to these stats.
                    LinkStats.IncrementStat(StatIndex.Weapon);
                    break;
                case 2:
                    LinkStats.IncrementStat(StatIndex.Con);
                    LinkStats.IncrementStat(StatIndex.Arm);
                    break;
                case 3:
                    LinkStats.IncrementStat(StatIndex.Wis);
                    LinkStats.IncrementStat(StatIndex.Arm);
                    break;
                case 4:
                    LinkStats.IncrementStat(StatIndex.Cha);
                    LinkStats.IncrementStat(StatIndex.Arm);
                    break;
                
            }
            TurnOffButtons();
        }
        private void WhenO2Q1Clicked(object sender, MouseEventArgs e)
        {
            switch (page)
            {
                case 1:
                    LinkStats.IncrementStat(StatIndex.Int);
                    LinkStats.IncrementStat(StatIndex.Magic);
                    break;
                case 2:
                    LinkStats.IncrementStat(StatIndex.Dex);
                    LinkStats.IncrementStat(StatIndex.Weapon);
                    break;
                case 3:
                    LinkStats.IncrementStat(StatIndex.Dex);
                    LinkStats.IncrementStat(StatIndex.Weapon);
                    break;
                case 4:
                    LinkStats.IncrementStat(StatIndex.Str);
                    LinkStats.IncrementStat(StatIndex.Weapon);
                    break;
            }
            TurnOffButtons();
        }
        private void WhenO3Q1Clicked(object sender, MouseEventArgs e)
        {
            switch (page)
            {
                case 1:
                    LinkStats.IncrementStat(StatIndex.Wis);
                    LinkStats.IncrementStat(StatIndex.Magic);
                    break;
                case 2:
                    LinkStats.IncrementStat(StatIndex.Wis);
                    LinkStats.IncrementStat(StatIndex.Magic);
                    break;
                case 3:
                    LinkStats.IncrementStat(StatIndex.Con);
                    LinkStats.IncrementStat(StatIndex.Arm);
                    break;
                case 4:
                    LinkStats.IncrementStat(StatIndex.Wis);
                    LinkStats.IncrementStat(StatIndex.Arm);
                    break;
            }
            TurnOffButtons();
        }
        private void WhenO4Q1Clicked(object sender, MouseEventArgs e)
        {
            switch (page)
            {
                case 1:
                    LinkStats.IncrementStat(StatIndex.Dex);
                    LinkStats.IncrementStat(StatIndex.Weapon);
                    break;
                case 2:
                    LinkStats.IncrementStat(StatIndex.Str);
                    LinkStats.IncrementStat(StatIndex.Basic);
                    break;
                case 3:
                    LinkStats.IncrementStat(StatIndex.Int);
                    LinkStats.IncrementStat(StatIndex.Basic);
                    break;
                case 4:
                    LinkStats.IncrementStat(StatIndex.Basic);
                    LinkStats.IncrementStat(StatIndex.Magic);
                    break;
            }
            TurnOffButtons();
        }

        private void WhenO5Q1Clicked(object sender, MouseEventArgs e)
        {
            switch (page)
            {
                case 1:
                    LinkStats.IncrementStat(StatIndex.Con);
                    LinkStats.IncrementStat(StatIndex.Arm);
                    break;
                case 2:
                    LinkStats.IncrementStat(StatIndex.Cha);
                    LinkStats.IncrementStat(StatIndex.Weapon);
                    break;
                case 3:
                    LinkStats.IncrementStat(StatIndex.Str);
                    LinkStats.IncrementStat(StatIndex.Weapon);
                    break;
                case 4:
                    LinkStats.IncrementStat(StatIndex.Con);
                    LinkStats.IncrementStat(StatIndex.Basic);
                    break;
            }
        }

        private void WhenO6Q1Clicked(object sender, MouseEventArgs e)
        {
            switch (page)
            {
                case 1:
                    LinkStats.IncrementStat(StatIndex.Cha);
                    LinkStats.IncrementStat(StatIndex.Arm);
                    break;
                case 2:
                    LinkStats.IncrementStat(StatIndex.Int);
                    LinkStats.IncrementStat(StatIndex.Magic);
                    break;
                case 3:
                    LinkStats.IncrementStat(StatIndex.Cha);
                    LinkStats.IncrementStat(StatIndex.Basic);
                    break;
                case 4:
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
                    LinkStats.Results();
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
    }
}
