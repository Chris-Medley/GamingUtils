// See https://aka.ms/new-console-template for more information

class Dice
{
    public static void RollDice(int[] diceInfoIn)
    {

        //generate and display the dice rolls

        for (int i = 0; i < diceInfoIn[1]; i++)
        {
            Random rand = new Random();
            int randNum = rand.Next(1, diceInfoIn[0]);
            Console.WriteLine(randNum);
        }


    }

    public static void RollCharacter()
    {
        //Set the descriptors to print out **look into multidimensional array in future for cleaner (if not easier)
        string[] abilities = { "Strength", "Dexterity", "Constitution", "Inteligence", "Wisdom", "Charisma" };

        //Create & set initial loop
        bool another = true;
        while (another == true)
        {
            //Generate and list random numbers between 6 & 18
            //surely there's a better way to put in a clear line

            Console.WriteLine(" ");
            Console.WriteLine("Your Scores");

            for (int k = 0; k < 6; k++)
            {
                int current = k;
                int[] randNum = new int[6];
                Random rand = new Random();
                randNum[current] = rand.Next(6, 19);
                Console.WriteLine($"{abilities[current]}:{randNum[current]}");

            }

            //Ask if they need MORE POWER!
            Console.WriteLine("Roll another character? (Affirmative/Yes or Negative/No)");
            string anotherInput = Console.ReadLine();

            //drop it down flip it and reverse it (actually just make it lower case)
            anotherInput = anotherInput.ToLower();

            //look into more string & array tools like StartsWith && Console.WriteLineIf
            if (anotherInput.StartsWith("a") || anotherInput.StartsWith("y"))

                another = true;

            else

                another = false;

            //Insert code here to write it out formated with ability scores pretty
        }
    }
}