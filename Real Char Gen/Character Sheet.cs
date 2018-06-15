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
    public partial class Character_Sheet : Form
    {
        private static Form1 LinkForm1;
        public Character_Sheet(Form1 Form1Link, PlayerStats LinkStats)
        {
            InitializeComponent();
            LinkForm1 = Form1Link;
            //Turns the text on the character sheet to the actual test results
            StrBaseText.Text = Convert.ToString(LinkStats.Str);
            StrLootText.Text = Convert.ToString(LinkStats.StrLoot);
            DexBaseText.Text = Convert.ToString(LinkStats.Dex);
            DexLootText.Text = Convert.ToString(LinkStats.DexLoot);
            ConBaseText.Text = Convert.ToString(LinkStats.Con);
            ConLootText.Text = Convert.ToString(LinkStats.ConLoot);
            IntBaseText.Text = Convert.ToString(LinkStats.Int);
            IntLootText.Text = Convert.ToString(LinkStats.IntLoot);
            WisBaseText.Text = Convert.ToString(LinkStats.Wis);
            WisLootText.Text = Convert.ToString(LinkStats.WisLoot);
            ChaBaseText.Text = Convert.ToString(LinkStats.Cha);
            ChaLootText.Text = Convert.ToString(LinkStats.ChaLoot);
            ArmorBaseText.Text = Convert.ToString(LinkStats.Arm);
            ArmorLootText.Text = Convert.ToString(LinkStats.ArmLoot);
            ArmorTotalText.Text = Convert.ToString(LinkStats.ArmLoot + LinkStats.Arm + 10);
            BasicBaseText.Text = Convert.ToString(LinkStats.Basic);
            BasicLootText.Text = Convert.ToString(LinkStats.BasicLoot);
            WeaponBaseText.Text = Convert.ToString(LinkStats.Weapon);
            WeaponLootText.Text = Convert.ToString(LinkStats.WeaponLoot);
            MagicBaseText.Text = Convert.ToString(LinkStats.Magic);
            MagicLootText.Text = Convert.ToString(LinkStats.MagicLoot);
            UltimateBaseText.Text = Convert.ToString(LinkStats.Ultimate);
            UltimateLootText.Text = Convert.ToString(LinkStats.UltimateLoot);
            //Inventory
            StarterRewardText.Text = LinkStats.StarterReward;
            StarterLootText.Text = LinkStats.StarterLoot;
            StarterWeaponsText.Text = LinkStats.StartingWeapons;
            StartingEquipmentText.Text = LinkStats.StartingEquipment;
            BioFormMod.Text = LinkStats.BioFormMod;
            //Race
            RaceText.Text = LinkStats.Race;
            //Class
            ClassText.Text = LinkStats.Class;

        }
        
        private void StarterLootText_Click(object sender, EventArgs e)
        {

        }

        private void StarterWeaponsText_Click(object sender, EventArgs e)
        {

        }

        private void Character_Sheet_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void StarterRewardText_Click(object sender, EventArgs e)
        {

        }

        private void ArmorText_Click(object sender, EventArgs e)
        {

        }
    }
}
