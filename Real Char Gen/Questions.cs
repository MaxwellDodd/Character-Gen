using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Char_Gen
{
    public class Questions
    {
        List<int> StatsList = new List<int>();
        public Form1 LinkForm1;
        private static PlayerStats LinkStats;
        public Questions (Form1 linkfm1, PlayerStats linkstats)
        {
            LinkForm1 = linkfm1;
            LinkStats = linkstats;
        }

        public void Q1()//text for question 1
        {
            LinkForm1.Question.Text = "An Orc hoard is seen in the distance and you and your friends are called upon to protect the town";
            LinkForm1.O1.Text = "Pick up your sword and honorably join the foot soldiers";
            LinkForm1.O2.Text = "Prepare your fireball spell to use on the dumb orcs knowing it\'s there weakness";
            LinkForm1.O3.Text = "Ask a higher power to bless the soldiers and grant them good health";
            LinkForm1.O4.Text = "Climb the barracks with a bow on your back so you can pick them off before they arrive";
            LinkForm1.O5.Text = "Join the front lines in the hopes of protecting soldiers and your friends";
            LinkForm1.O6.Text = "Take Charge with your war horn and command the town soldiers";
        }
        public void Q2()//question 2 etc.
        {
            LinkForm1.Question.Text = "On your travels you and your party are caught in a goblin trap! Rocks are tumbling down the hill to crush you!";
            LinkForm1.O1.Text = "You're wearing so much armor that a few rocks won't hurt you";
            LinkForm1.O2.Text = "Deftly dodge each rock and dash to safety";
            LinkForm1.O3.Text = "After the rocks have fallen you heal your wounded friends";
            LinkForm1.O4.Text = "Catch the rocks before they hit your party";
            LinkForm1.O5.Text = "Taunt the Goblins to come down and fight like real Goblins!";
            LinkForm1.O6.Text = "Stand behind a tree and cast arcane missiles at the Goblins or the rocks";
        }
        public void Q3()
        {
            LinkForm1.Question.Text = "You sit across the table from a man forced into a game of wits. Two goblets sit on the table and he claims one of them is poisoned. He says you must drink one.";
            LinkForm1.O1.Text = "Smell the contents in each goblet and drink from the one that you do not detect the poison in.";
            LinkForm1.O2.Text = "Switch the goblets without him noticing.";
            LinkForm1.O3.Text = "Drink from the closest goblet knowing that you have a strong immune system.";
            LinkForm1.O4.Text = "Drink the closest one knowing where you can find the antidote for the poison.";
            LinkForm1.O5.Text = "Burry your axe in the man\'s skull before he can say \"Inconcievable!\"";
            LinkForm1.O6.Text = "Convince him to unwittingly tell you which goblet contains the poison.";
        }
        public void Q4()
        {
            LinkForm1.Question.Text = "You're out on the high seas and your frigate is besieged by an enormous Kraken!!";
            LinkForm1.O1.Text = "Stand at the helm shouting orders leading the crew.";
            LinkForm1.O2.Text = "Swing from the masts with sword in hand and slash at the tentacles.";
            LinkForm1.O3.Text = "Stay in the Crow\'s Nest calling out the Kraken\'s location and where it will strike next.";
            LinkForm1.O4.Text = "Try and scare the Kraken away by blasting it with a fire spell.";
            LinkForm1.O5.Text = "Repair the ship below deck so that you don't sink!";
            LinkForm1.O6.Text = "Man the swivel cannon, aiming at the vitals.";
        }
        public void Q5()
        {
            LinkForm1.Question.Text = "Ask your Game Master, AKA the person who asked you to make this character, if you are using the Warpshell or Alfheim setting";
            LinkForm1.O1.Text = "Warpshell";
            LinkForm1.O2.Text = "Alfheim";
        }
        public void Q6()
        {
            LinkForm1.Question.Text = "Which Bio Form/Race would you like?";
            if (LinkStats.Setting == true) { LinkForm1.O1.Text = "Elf: More dexterous and intelligent"; }//Elf
            else { LinkForm1.O1.Text = "Mecha: Thinking and feeling robot."; }//Mecha
            if (LinkStats.Setting == true) { LinkForm1.O2.Text = "Dwarf: Hardy and charismatic"; }//Dwarf
            else { LinkForm1.O2.Text = "Reptoid:  walking lizard with an odd lack of emotions and primal instincts."; }//Reptoid
            if (LinkStats.Setting == true) { LinkForm1.O3.Text = "Small Folk: Wise and more potent with magic"; }//Small Folk
            else { LinkForm1.O3.Text = "Psyker: A strange, grey-skinned founder-race of telepaths and super-scientists"; }//Psyker
            if (LinkStats.Setting == true) { LinkForm1.O4.Text = "Human: Smart and more dangerous with a weapon"; }
            else { LinkForm1.O4.Text = "Geno: Basically a human. Versatile, fragile, and indomitable"; }//Geno
            if (LinkStats.Setting == true) { LinkForm1.O5.Text = "Hill Folk: Strong and excellent and manual labor"; }
            else { LinkForm1.O5.Text = "Xill: bio-genereated micro gravity field to realign their chitinous body components"; }
        }

        
    }
}
