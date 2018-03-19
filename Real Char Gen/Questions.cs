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
        public Questions (Form1 linkfm1)
        {
            LinkForm1 = linkfm1;
        }
        public void Q1()//text for question 1
        {
            LinkForm1.textBox1.Text = "An Orc hoard is seen in the distance and you and your friends are called upon to protect the town";
            LinkForm1.O1.Text = "Pick up your sword and honorably join the foot soldiers";
            LinkForm1.O2.Text = "Prepare your fireball spell to use on the dumb orcs knowing it\'s there weakness";
            LinkForm1.O3.Text = "Ask a higher power to bless the soldiers and grant them good health";
            LinkForm1.O4.Text = "Climb the barracks with a bow on your back so you can pick them off before they arrive";
            LinkForm1.O5.Text = "Join the front lines in the hopes of protecting soldiers and your friends";
            LinkForm1.O6.Text = "Take Charge with your war horn and command the town soldiers";
        }
        public void Q2()//question 2 etc.
        {
            LinkForm1.textBox1.Text = "On your travels you and your party are caught in a goblin trap! Rocks are tumbling down the hill to crush you!";
            LinkForm1.O1.Text = "You're wearing so much armor that a few rocks won't hurt you";
            LinkForm1.O2.Text = "After the rocks have fallen you heal your wounded friends";
            LinkForm1.O3.Text = "Catch the rocks before they hit your party";
            LinkForm1.O4.Text = "Taunt the Goblins to come down and fight lik a real Goblin";
            LinkForm1.O5.Text = "Deftly dodge each rock and dash to safety";
            LinkForm1.O6.Text = "Stand behind a tree and cast arcane missiles at the Goblins or the rocks";
        }
        public void Q3()
        {
            LinkForm1.textBox1.Text = "You sit across the table from a man forced into a game of wits. Two goblets sit on the table and he claims one of them is poisoned. He says you must drink one.";
            LinkForm1.O1.Text = "Smell the contents in each goblet and drink from the one that you do not detect the poison in.";
            LinkForm1.O2.Text = "Switch the goblets without him noticing.";
            LinkForm1.O3.Text = "Drink from the closest goblet knowing that you have a strong immune system.";
            LinkForm1.O4.Text = "Drink the closest one knowing where you can find hte antidote for the poison.";
            LinkForm1.O5.Text = "Burry your axe in hte man\'s skull before he can say \"Inconcievable!\"";
            LinkForm1.O6.Text = "Convince him to unwittingly tell you which goblet contains the poison.";
        }
        public void Q4()
        {
            LinkForm1.textBox1.Text = "You're out on the high seas and your frigate is besieged by an enormous Kraken!!";
            LinkForm1.O1.Text = "Stand at ht ehelm shouting orders leading the crew.";
            LinkForm1.O2.Text = "Swing from hte masts with sword in hand and slash at the tentacles.";
            LinkForm1.O3.Text = "Stay in the Crow\'s Nest calling out the Kraken\'s location and where it will strike next.";
            LinkForm1.O4.Text = "Try and scare the Kraken away by blasting it with a fire spell.";
            LinkForm1.O5.Text = "Repair the ship below deck so that you don't sink!";
            LinkForm1.O6.Text = "Man the swivel cannon, aiming at the vitals.";
        }
        
    }
}
