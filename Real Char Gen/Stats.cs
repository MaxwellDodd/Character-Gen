using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Char_Gen
{
    public enum StatIndex : int
    {
        Str,
        Dex,
        Con,
        Int,
        Wis,
        Cha,
        Arm,
        Basic,
        Weapon,
        Magic,
        Ultimate,
    }


    public class PlayerStats
    {
        private const int StatCount = (int)StatIndex.Ultimate + 1;
        private int[] All = new int[StatCount];

        // Helper methods to get and set a property using a stat index.
        public string StarterReward;//Starting Reward
        public string Class;//Class
        public bool Setting;//true = alfheim. false = Warpshell
        public string Race;//Race
        public string StarterLoot;//StarterLoot
        public string StartingWeapons;//Weapons
        public string StartingEquipment;//Equipment
        public string BioFormMod;//For mecha to add extra health
        //The loot bonuses to for the stats
        public int StrLoot;
        public int DexLoot;
        public int ConLoot;
        public int IntLoot;
        public int WisLoot;
        public int ChaLoot;
        public int ArmLoot;
        public int BasicLoot;
        public int WeaponLoot;
        public int MagicLoot;
        public int UltimateLoot;



        public int GetProperty(StatIndex i)
        {
            return All[(int)i];
        }

        public void SetProperty(StatIndex i, int value)
        {
            All[(int)i] = value;
        }
        public void IncrementStat(StatIndex index)
        {
            All[(int)index] = All[(int)index] + 1;//Adds one to the stat that is passed to it.
        }
        // Convenience properties to refer to individual stats by name.
        public int Str
        {
            get { return GetProperty(StatIndex.Str); }
            set { SetProperty(StatIndex.Str, value); }
        }
        public int Dex
        {
            get { return GetProperty(StatIndex.Dex); }
            set { SetProperty(StatIndex.Dex, value); }
        }
        public int Con
        {
            get { return GetProperty(StatIndex.Con); }
            set { SetProperty(StatIndex.Con, value); }
        }
        public int Int
        {
            get { return GetProperty(StatIndex.Int); }
            set { SetProperty(StatIndex.Int, value); }
        }
        public int Wis
        {
            get { return GetProperty(StatIndex.Wis); }
            set { SetProperty(StatIndex.Wis, value); }
        }
        public int Cha
        {
            get { return GetProperty(StatIndex.Cha); }
            set { SetProperty(StatIndex.Cha, value); }
        }
        public int Arm
        {
            get { return GetProperty(StatIndex.Arm); }
            set { SetProperty(StatIndex.Arm, value); }
        }
        public int Basic
        {
            get { return GetProperty(StatIndex.Basic); }
            set { SetProperty(StatIndex.Basic, value); }
        }
        public int Weapon
        {
            get { return GetProperty(StatIndex.Weapon); }
            set { SetProperty(StatIndex.Weapon, value); }
        }
        public int Magic
        {
            get { return GetProperty(StatIndex.Magic); }
            set { SetProperty(StatIndex.Magic, value); }
        }
        public int Ultimate
        {
            get { return GetProperty(StatIndex.Ultimate); }
            set { SetProperty(StatIndex.Ultimate, value); }
        }
        // Define more properties here

        // Get the stat index of the stat with the maximum value.
        public StatIndex GetBestStat(out int bestValue)
        {
            int bestIndex = 0;
            bestValue = All[0];

            for (int i = 1; i < StatCount; i++)
            {
                int value = All[i];
                if (value > bestValue)
                {
                    bestIndex = i;
                    bestValue = value;
                }
            }
            return (StatIndex)bestIndex;//the number in the array of the best stat
          }

        public StatIndex BestStatIndex
        {
            get { int bestValue; return GetBestStat(out bestValue); }//best stat name
        }

        public int BestStatValue
        {
            get { int bestValue; GetBestStat(out bestValue); return bestValue; }//best stat number
        }

        private void Geno()
        {
            if (Class == "Tank") { Arm++; Con++; }
            else if (Class == "Ronin") { Weapon++; Str++; }
            else if (Class == "Ghost") { Str++; Dex++; }
            else if (Class == "Gunner") { Dex++; Weapon++; }
            else if (Class == "Zurin") { Wis++; Magic++; }
            else if (Class == "Blip") { Wis++; Dex++; }
            else if (Class == "Fragment") { Int++; Magic++; }
            else if (Class == "Titan") { Cha++; Str++; }
            else if (Class == "Outsider") { Int++; Basic++; }
        }

        public void Results()
        {
            if (Setting == true) // true is Alfheim false is Warpshell
            {
                if (Race == "Elf") { Dex++; Int++; }
                else if (Race == "Dwarf") { Con++; Cha++; }
                else if (Race == "Small Folk") { Wis++; Magic++; }
                else if (Race == "Human") { Int++; Weapon++; }
                else if (Race == "Hill Folk") { Str++; Basic += 3; }
            }
            else
            {
                if (Race == "Mecha") { Str++; BioFormMod = "+10"; }
                if (Race == "Reptiod") { Dex++; BioFormMod = "Hear vision, Any surface walkable";  }
                if (Race == "Psyker") { Int++; BioFormMod = "Use an INT check to read minds, Limited telekinetics"; }
                //if (Race == "Geno") {   } //put ++ for each different class once those are added
                if (Race == "Xill") { Con++; BioFormMod = "Immune to vacuum"; Arm++; }
            }

            if (Setting == true)
            {
                if (Weapon >= BestStatValue && Dex > Str)//Archer
                {
                    Class = "Archer";
                    StarterReward = "Speed Quiver: If ranged attack roll is 13 or higher, fire again";
                    if (Magic > 0) { StarterLoot = "20 Magic Arrows"; } else { StarterLoot = "Masterful Boots"; DexLoot++; }//StarterLoot
                    StartingWeapons = "Long Bow " + "Dagger ";
                    StartingEquipment = "Supplies Pack: Food, Flint, 3 Flares " + "Common Armor "; ArmLoot++;
                    if (StarterLoot == "20 Magic Arrows") { StartingEquipment += "Spell Book, Magic Effort Explodes"; } else { StartingEquipment += "Tools: Medicine"; }//Equipment
                }
                else if (Dex >= BestStatValue)//Shadow
                {
                    Class = "Shadow";
                    StarterReward = "Thief's Hood: Stealth rolls always EASY";
                    StarterLoot = "Greedy Gloves: Any time you roll for LOOT, roll TWICE";
                    StartingWeapons = "Dagger " + "Short Bow " + "Sling ";
                    StartingEquipment = "Rope & Hook, +3 DEX when climbing " + "Pouch of 50 Coin " + "Tools: +3 Lockpicking ";
                }
                else if (Magic > 1 && Wis >= Int)//Priest
                {
                    Class = "Priest";
                    StarterReward = "WIS Power: Healing Touch: Touch an ally with WIS, heal with Magical Effort";
                    StarterLoot = "Meditation Beads"; WisLoot++;
                    StartingWeapons = "Staff ";
                    if (Str > 0) { StartingWeapons += "Dagger"; } else { StartingWeapons += "Sling"; }//weapons
                    StartingEquipment = "Spell Book, Magic Effort Explodes " + "Common Armor " + "Instrument, +3 CHA when performing "; ArmLoot++;
                }
                else if (Wis >= BestStatValue)//Scout
                {
                    Class = "Scout";
                    StarterReward = "Winged Boots: Move, perform any non-Attack action, and Move again";
                    StarterLoot = "Spyglass: +3 WIS when Scouting";
                    StartingWeapons = "Short Bow ";
                    if (Dex >= Str) { StartingWeapons += "Dagger"; } else { StartingWeapons += "Short Sword"; }//Weapons
                    StartingEquipment = "Rope & Hook, +3 DEX when climbing " + "Tools: +3 Lockpicking " + "Commong Armor ";
                }
                else if (Magic > 1 && Int >= Wis || Int >= BestStatValue)//Mage
                {
                    Class = "Mage";
                    StarterReward = "INT Spell: Arcane Missile (INT Attempt on a target in sight)";
                    if (Int >= 2) { StarterLoot = "Fire Stone"; MagicLoot++; } else { StarterLoot = "Book of Secrets"; Int++; }
                    StartingWeapons = "Staff ";
                    if (Dex >= Str) { StartingWeapons += "Short Bow "; } else { StartingWeapons += "Short Sword"; }//Weapons
                    StartingEquipment = "Spell Book, Magic Effort Explodes " + "Common Armor " + "Supplies Pack: Food, Flint, 3 Flares "; ArmLoot++;
                }
                else if (Cha >= BestStatValue)//Commander
                {
                    Class = "Commander";
                    StarterReward = "Amulet of Kings (+5 CHA when commanding, intimidating, or persuading)";
                    StarterLoot = "Masterful Coats"; ChaLoot++;
                    StartingWeapons = "Dagger ";
                    if (Dex >= Str) { StartingWeapons += "Long Bow"; } else { StartingWeapons += "Long Sword"; }//weapons
                    StartingEquipment = "Common Armor " + "Instrument, +3 CHA when performing " + "Common Shield"; ArmLoot += 2;
                }
                else if (Basic >= BestStatValue)//Wilding
                {
                    Class = "Wildling";
                    StarterReward = "Hillman's Belt (Always roll ULTIMATE when doing Basic Effort)";
                    Ultimate = Basic;
                    Basic = 0;
                    StarterLoot = "Beserker Ring"; UltimateLoot += 3;
                    StartingWeapons = "Staff";
                    if (Dex >= Str) { StartingWeapons += "Short Bow "; } else { StartingWeapons += "Club "; }
                    StartingEquipment = "Supplies Pack: Food, Flint, 3 Flares " + "Trapper Gear: Snare, Tackle, Tent " + "Tools: +3 Woodworking";
                }
                else if (Weapon >= BestStatValue && Str > Dex || Str >= BestStatValue)//Blade
                {
                    Class = "Blade";
                    StarterReward = "Weapon Gem: deal an extra +3 EFFORT with one item";
                    WeaponLoot += 3;
                    StarterLoot = "Weapon Kit"; WeaponLoot += 2;
                    if (Dex > Arm || Dex > Str) { StartingWeapons = "Bow "; } else { StartingWeapons = "Spear "; }//starting weapons
                    StartingWeapons += "Long Sword " + "Dagger ";
                    if (Con > Dex) { StartingEquipment = "Common Shield"; ArmLoot += 2; } else { StartingEquipment = "Trapper Gear: Snares, Tackle, Tent "; };
                    StartingEquipment += "Common Armor " + "Rope & Hook, +3 DEX when climbing "; ArmLoot++;//armor
                }
                else if (Arm >= BestStatValue || Con >= BestStatValue)//Guardian
                {
                    Class = "Guardian";
                    StarterReward = "Shield Gloves";
                    ArmLoot += Con;//For Shield Gloves
                    if (Str > Con) { StarterLoot = "Trusty Mug"; ConLoot++; } else { StarterLoot = "Ring of Might"; StrLoot++; }//starting loot
                    StartingWeapons = "Hammer " + "Short Sword ";
                    StartingEquipment = "Common Shield " + "Common Armor "; ArmLoot += 3;
                    if (Int > 0) { StartingEquipment += "Tools: +3 Medicine"; } else { StartingEquipment += "Pouch of 50 Coin"; }
                }
            }
            else//When Warpshell is chosen
            {
                if (Weapon >= BestStatValue && Dex >= Str)//Gunner
                {
                    Class = "Gunner";
                    Geno();
                    StarterReward = "Burst Fire Unit: On hit roll EFFORT 3 times and distribute between targets";
                    if (Magic > 0) { StarterLoot = "20 Magic Arrows"; } else { StarterLoot = "Masterful Boots"; DexLoot++; }//StarterLoot
                    StartingWeapons = "Gauss Launcher " + "Pulse Rifle ";
                    StartingEquipment = "Supplies Pack: Food, Flint, 3 Flares " + "Common Armor "; ArmLoot++;//For Common Armor
                    if (StarterLoot == "20 Magic Arrows") { StartingEquipment += "Spell Book, Magic Effort Explodes"; } else { StartingEquipment += "Tools: Medicine"; StartingEquipment += "Common Armor"; ArmLoot++; }//Equipment
                }
                else if (Dex >= BestStatValue)//Ghost
                {
                    Class = "Ghost";
                    Geno();
                    StarterReward = "Stealth Module: DEX attempt, go invisible until touch";
                    StarterLoot = "Greedy Gloves: Any time you roll for LOOT, roll TWICE";
                    StartingWeapons = "Energy Bow " + "Duranium Blade ";
                    StartingEquipment = "Rope & Hook, +3 DEX when climbing " + "Common Armor " + "Tools: +3 Lockpicking "; ArmLoot++;//for Common Armor
                }
                
                else if (Magic > 1 && Wis >= Int)//Zurin old:Wis >= BestStatValue && Magic >= Dex
                {
                    Class = "Zurin";
                    Geno();
                    StarterReward = "Healin                                                                                                                                                                   g Words: WIS Attempt, heal with Magic Effort ";
                    StarterLoot = "Meditation Beads"; WisLoot++;
                    StartingWeapons += "Energy Blade "; StartingWeapons += "Blast Pistol"; 
                    StartingEquipment = "Spell Book, Magic Effort Explodes " + "Common Armor " + "Instrument, +3 CHA when performing "; ArmLoot++;//For Common Armor
                }
                else if (Wis >= BestStatValue)//Blip
                {
                    Class = "Blip";
                    Geno();
                    StarterReward = "Phase Core: Make NEAR move without traveling between";
                    StarterLoot = "Spyglass: +3 WIS when Scouting";
                    StartingWeapons += "Blast Pistol "; StartingWeapons += "Ion Grenade ";
                    StartingEquipment = "Rope & Hook, +3 DEX when climbing " + "Tools: +3 Lockpicking " + "Commong Armor "; ArmLoot++;//For Common Armor
                }
                else if (Int >= BestStatValue || Magic > 1 && Int > Wis)//Fragment old: Int >= BestStatValue
                {
                    Class = "Fragment";
                    Geno();
                    StarterReward = "INT Spell: Fire Missile (INT Attempt on a target in sight, Ignites flammables)";
                    if (Int >= 2) { StarterLoot = "Fire Stone"; MagicLoot++; } else { StarterLoot = "Book of Secrets"; Int++; }
                    StartingWeapons = "Arc Spear ";
                    StartingEquipment = "Spell Book, Magic Effort Explodes " + "Common Armor " + "Supplies Pack: Food, Flint, 3 Flares "; ArmLoot++;
                }
                else if (Cha >= BestStatValue)//Titan
                {
                    Class = "Titan";
                    Geno();
                    StarterReward = "Drain-Star: For each 5 Damage you deal, heal 1 Hit Point";
                    StarterLoot = "Masterful Coats"; ChaLoot++;
                    StartingWeapons = "Dagger ";
                    if (Dex >= Str) { StartingWeapons += "Pulse Rifle "; } else { StartingWeapons += "Duranium Great Sword"; } StartingWeapons += "Impervium Shield "; //weapons
                    StartingEquipment = "Common Armor " + "Instrument, +3 CHA when performing " + "Common Shield"; ArmLoot += 3; //Plus 2 from shield 1 from armor
                }
                else if (Basic >= BestStatValue)//Outsider
                {
                    Class = "Outsider";
                    Geno();
                    StarterReward = "Matter Distention Coil: Roll INT, become stretchy for 1 turn";
                    StarterLoot = "Amulet of Secrets"; IntLoot++;
                    StartingWeapons = "Arc Spear";
                    if (Dex >= Str) { StartingWeapons += "Pulse Rifle "; } else { StartingWeapons += "Machete"; }
                    StartingEquipment = "Supplies Pack: Food, Flint, 3 Flares " + "Trapper Gear: Snare, Tackle, Tent " + "Tools: +3 tech";
                }
                else if (Weapon >= BestStatValue && Str > Dex || Str >= BestStatValue)//Ronin
                {
                    Class = "Ronin";
                    Geno();
                    StarterReward = "Drone Kit: One weapon is a remote operated drone";
                    StarterLoot = "Weapon Kit"; WeaponLoot += 2;
                    if (Dex > Str) { StartingWeapons = "Blast Rifle "; } else { StartingWeapons = "Duranium Great Sword "; }//starting weapons
                    StartingWeapons += "Blast Pistol " + "Dagger ";
                    if (Con > Dex) { StartingEquipment = "Common Shield"; ArmLoot += 2; } else { StartingEquipment = "Trapper Gear: Snares, Tackle, Tent "; }
                    StartingEquipment += "Common Armor " + "Rope & Hook, +3 DEX when climbing "; ArmLoot++;//For common Armor
                }
                else if (Arm >= BestStatValue || Con >= BestStatValue)//Tank
                {
                    Class = "Tank";
                    Geno();
                    StarterReward = "Shield Module: Ignore any damage of 4 or less";
                    if (Str > Con) { StarterLoot = "Trusty Mug"; ConLoot++; } else { StarterLoot = "Ring of Might"; StrLoot++; }//starting loot
                    StartingWeapons = "Energy Shield " + "Blast Pistol " + "Impervium Shield";
                    StartingEquipment = "Common Shield " + "Common Armor "; ArmLoot += 3;//shield +2 armor +1
                    if (Int > 0) { StartingEquipment += "Tools: +3 Medicine"; } else { StartingEquipment += "Pouch of 50 Coin"; }
                }
                

            }
            //Console.WriteLine(BestStatIndex);
            //foreach (int i in All)
            //{
            //Console.WriteLine(All[i]);
            //}
        }
    }
}