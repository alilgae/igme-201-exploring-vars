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

            //concat

            heroFullName = heroFirstName + " " + heroLastName;

            Console.WriteLine("Behold, the glorious hero!");
            Console.WriteLine(heroFullName);
        }
    }
}
