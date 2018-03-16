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
        Ultimate
    }

    public class PlayerStats
    {
        private const int StatCount = (int)StatIndex.Ultimate + 1;
        private int[] All = new int[StatCount];

        // Helper methods to get and set a property using a stat index.
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
            
            int current = All[(int)index];
            All[(int)index] = current++;
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
        public void Results()
        {
            Console.WriteLine(BestStatIndex);
        }
    }
}