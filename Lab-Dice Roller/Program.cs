﻿bool playAgain = true;

while (playAgain) 
{
    bool rollAgain = true;
    int numberOfSidesOnDice = 0;
    int diceRollCount = 1;

    BenderFace();
      
    Console.WriteLine("Welcome To Bender's Definitely Not Rigged");
    Console.WriteLine("Dice Roller Game!");
    Console.WriteLine();
    //Console.ReadKey();
    Console.WriteLine("Ok Meatbag Let's Get Gambling!");
    Console.ReadKey();
    Console.Clear();
    
    numberOfSidesOnDice = NumberOfSidesOnDice(numberOfSidesOnDice);
    Console.ReadKey();

    Console.Clear();
    BenderFace();

    Console.WriteLine("Here's The Fun And Totally Not Rigged Part");
    Console.WriteLine("Press Any Key To Roll Those Dice Sucker");
    Console.ReadKey();

    while (rollAgain)
    {   
        Console.WriteLine();
        Console.WriteLine($"Roll Number {diceRollCount}");
        Console.WriteLine();
        
        int diceOne = RollDice(numberOfSidesOnDice);
        int diceTwo = RollDice(numberOfSidesOnDice);

        Console.WriteLine($"You Rolled {diceOne} And {diceTwo}");
        if(numberOfSidesOnDice == 6)
        {
            string sixSideDiceResult = SixSidedDiceWins(diceOne, diceTwo, out string outputCraps);
            Console.WriteLine(sixSideDiceResult);
            if (!outputCraps.Equals(""))
            {
                Console.WriteLine(outputCraps);
            }
        }
        else
        {
            Console.WriteLine("Ha Ha You Loose!");
            Console.WriteLine("Now HAND OVER YOUR WALLET!");
        }
        Console.WriteLine();
        diceRollCount++;
        rollAgain = PlayAgain("Roll");
        Console.Clear();
        BenderFace();
    }   
        
    Console.Clear();
    BenderFace();

    if (PlayAgain("Play"))
    {
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Beat It Jerk!");
        Environment.Exit(0);
    }
} 

bool PlayAgain(string typeOfRepeat)
{
    Console.WriteLine($"Would You Like To {typeOfRepeat} Again (y/n)?");
    string input = Console.ReadLine();
    playAgain = input.ToLower() == "y";
    return playAgain;
}

int NumberOfSidesOnDice(int numberOfSidesOnDice)
{
    bool isValid;

    BenderFace();

    Console.WriteLine("Here's The Deal, You Get To Roll Two Dice And See If You Win");
    Console.WriteLine("Since I'm Feeling So Nice, I'll Let You Choose How Many Sides Are On The Dice");
    Console.WriteLine();
    do
    {
        Console.WriteLine("Enter A Number:");
        isValid = int.TryParse(Console.ReadLine(), out numberOfSidesOnDice) && (numberOfSidesOnDice>=6);
        if (!isValid)
        {
            Console.WriteLine(); 
            if (numberOfSidesOnDice < 6)
            {
                Console.WriteLine($"{numberOfSidesOnDice}?? A Dice Has To Have At Least 6 Sides");
            }
            Console.WriteLine("What Is This? Did Zoidberg Write That? Try Again Meatbag!");
            Console.WriteLine();
        }
    }while (!isValid);

    Console.WriteLine();
    Console.WriteLine($"Ok So {numberOfSidesOnDice} Sided Dice, You Got It");
    
    return numberOfSidesOnDice;
}

int RollDice(int numberOfSidesOnDice)
{
    Random random = new Random();
    int diceRollResult = random.Next(1, (numberOfSidesOnDice+1));
    return diceRollResult;
}

string SixSidedDiceWins(int dice1, int dice2, out string outputCraps)
{
    string winResultString;
    int dicetotal = dice1 + dice2;

    if (dice1 == 1 && dice2 == 1)
    {
        winResultString = "Snake Eyes!";
    }
    else if ((dice1 == 1 && dice2 == 2) || (dice1 == 2 && dice2 == 1))
    {
        winResultString = "Ace Deuce!";
    }else if (dice1 == 6 && dice2 == 6)
    {
        winResultString = "Box Car!";
    }else if (dicetotal == 7 || dicetotal == 11)
    {
        winResultString = "WIN!\n" + "WAIT WHAT??\n" + "MY SWAG!";
    }
    else
    {
        winResultString = "Pay Up Chump!";
    }

    if(dicetotal == 2 ||dicetotal == 3 || dicetotal == 12)
    {
        outputCraps = "CRAPS!";
    }
    else
    {
        outputCraps = "";
    }
    
    return winResultString;
}

void BenderFace() 
{
    Console.WriteLine("─────────────────────────────");
    Console.WriteLine("─────────────▐█▌─────────────");
    Console.WriteLine("─────────────▐░▌─────────────");
    Console.WriteLine("─────────────▐░▌─────────────");
    Console.WriteLine("─────────────▐░▌─────────────");
    Console.WriteLine("──────────▄▄▀░░░▀▄▄──────────");
    Console.WriteLine("────────▄▀░░░░░░░░░▀▄────────");
    Console.WriteLine("──────▄▀░░░░░░░░░░░░░▀▄──────");
    Console.WriteLine("─────▐░░░░░░░░░░░░░░░░░▌─────");
    Console.WriteLine("────▐░░░░░░░░░░░░░░░░░░░▌────");
    Console.WriteLine("───▐░░░░░░░░░░░░░░░░░░░░░▌───");
    Console.WriteLine("───▐░░░░░░░░░░░░░░░░░░░░░▌───");
    Console.WriteLine("───▐▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▌───");
    Console.WriteLine("──▄███████████████████████▄──");
    Console.WriteLine("─████▀────▀███████▀────▀███▄─");
    Console.WriteLine("─███▀───────█████────────███─");
    Console.WriteLine("─███───███───███───███───███─");
    Console.WriteLine("─███───▀▀▀───███───▀▀▀───███─");
    Console.WriteLine("─▀███▄─────▄█████▄─────▄███▀─");
    Console.WriteLine("──▀███████████████████████▀──");
    Console.WriteLine("───▐░░░░░░░░░░░░░░░░░░░░░▌───");
    Console.WriteLine("───▐░▄▀▀█▀▀█▀▀█▀▀█▀▀█▀▀▄░▌───");
    Console.WriteLine("───▐░█▄▄█▄▄█▄▄█▄▄█▄▄█▄▄█░▌───");
    Console.WriteLine("───▐░█──█──█──█──█──█──█░▌───");
    Console.WriteLine("───▐░█▀▀█▀▀█▀▀█▀▀█▀▀█▀▀█░▌───");
    Console.WriteLine("───▐░▀▄▄█▄▄█▄▄█▄▄█▄▄█▄▄▀░▌───");
    Console.WriteLine("───▐░░░░░░░░░░░░░░░░░░░░░▌───");
    Console.WriteLine();

}
