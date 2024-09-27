namespace Exploring_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables 
            string heroFirstName = "Kaiden";
            string heroLastName = "Terrana";
            string heroFullName;

            string villianName;
            string villianTitle = "Master of Shadows";

            string minionTitle = "Placeholder Text";
            string minionName1;
            string minionName2;

            int heroHealth = 100, heroStrength = 50;
            int bossHealth = 100, bossStrength = 25; 
            int minion1Health = 50, minion2Health = 50, minionStrength = 5;

            //introductions

            heroFullName = heroFirstName + " " + heroLastName;

            Console.WriteLine("Behold, the glorious hero, whose name is " + heroFullName);

            villianName = "Steve";
            minionName1 = "Minion 001";
            minionName2 = "Minion 002";

            Console.WriteLine(heroFullName + "'s arch rival is " + villianName + " the " + villianTitle);

            Console.WriteLine(villianName + " the " + villianTitle + " is helped by " + 
                minionTitle + " " + minionName1 + " and " + minionTitle + " " + minionName2);

            //fight! 

            Console.WriteLine("the fighters enter the arena!");
            Console.WriteLine("Hero's health: " + heroHealth);
            Console.WriteLine("Boss's health: " + bossHealth);
            Console.WriteLine("Minion 1's health: " + minion1Health);
            Console.WriteLine("Minion 2's health: " + minion2Health);
            Console.WriteLine();

            //initiative: boss, minion 1, hero, minion 2
            Console.WriteLine(villianName + " the " + villianTitle + " attacks " + heroFullName);
            heroHealth -= bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            Console.WriteLine(minionName1 + " attacks " + heroFullName); 
            heroHealth -= minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            Console.WriteLine(heroFullName + " attacks " + minionName1);
            minion1Health -= heroStrength;
            Console.WriteLine(minionName1 + " now has " + minion1Health + " health!");
            Console.WriteLine(minionName1 + " defeated!");

            Console.WriteLine(heroFullName + " also attacks " + villianName);
            bossHealth -= heroStrength;
            Console.WriteLine(villianName + " now has " + bossHealth + " health!");

            Console.WriteLine(minionName2 + " attacks " + villianName + " ...What?");
            bossHealth -= minionStrength;
            Console.WriteLine(villianName + " now has " + bossHealth + " health!");
            Console.WriteLine();

            // end round 1
            Console.WriteLine(heroFullName + " has " + heroHealth + " health!");
            Console.WriteLine(heroFullName + " eats an apple to restore health! Yum!");
            heroHealth++;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            Console.WriteLine();

            Console.WriteLine(villianName + " has " + bossHealth + " health!");
            Console.WriteLine(villianName + " drinks a potion to restore health!");
            bossHealth += 5;
            Console.WriteLine();

            // round 2 - boss, hero, minion 2
            Console.WriteLine(villianName + " the " + villianTitle + " attacks " + heroFullName);
            heroHealth -= bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            Console.WriteLine(heroFullName + " attacks " + minionName2);
            minion2Health -= heroStrength;
            Console.WriteLine(minionName2 + " now has " + minion2Health + " health!");
            Console.WriteLine(minionName2 + " defeated!");

            Console.WriteLine(heroFullName + " also attacks " + villianName);
            bossHealth -= heroStrength;
            Console.WriteLine(villianName + " now has " + bossHealth + " health!");
            Console.WriteLine(villianName + " the " + villianTitle + " defeated!");
            Console.WriteLine();

            // end round 2
            Console.WriteLine(heroFullName + " is victorious!");
            Console.WriteLine("Wealth, glory, and straight A+'s to the winner!");
        }
    }
}
