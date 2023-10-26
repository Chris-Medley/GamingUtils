// See https://aka.ms/new-console-template for more information


//chose what to call
Console.WriteLine("Roll Dice or Roll Character?");
string option = Console.ReadLine();
option = option.ToLower();

if (option == "roll dice")

{
    //Set the initial array
    int[] diceInfoOut = { 0, 0 };

    //Get type of die cleanly
    Console.WriteLine("How many faces on the die?");
    if (!int.TryParse(Console.ReadLine(), out diceInfoOut[0]))
    {
        Console.WriteLine("Integers only please.");
        Environment.Exit(0);
    }
    else if (diceInfoOut[0] < 2)
    {
        Console.WriteLine("Greater than one please.");
        Environment.Exit(0);
    }

    //Get how many rolls cleanly
    Console.WriteLine("How many rolls of the die?");
    if (!int.TryParse(Console.ReadLine(), out diceInfoOut[1]))
    {
        Console.WriteLine("Integers only please.");
        Environment.Exit(0);
    }
    else if (diceInfoOut[1] == 0)
    {
        Console.WriteLine("Greater than zero please.");
        Environment.Exit(0);
    }

    //JUST ROLL IT!

    Dice.RollDice(diceInfoOut);
    Console.WriteLine(" ");
    Console.WriteLine("fin");

}

else if (option == "roll character")
{
    Dice.RollCharacter();
    Console.WriteLine(" ");
    Console.WriteLine("fin");
}

else

    Console.WriteLine("Invalid Selection.");
//do I want to return to 10 here?