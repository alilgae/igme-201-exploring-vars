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

            
        }
    }
}
