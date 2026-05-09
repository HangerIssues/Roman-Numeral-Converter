//Accepts values between 1 and 100
while (true)
{
    Console.WriteLine("Enter a whole number between 1 and 100: ");
    string? input = Console.ReadLine();
    if (input == null)
    {
        Console.WriteLine("I said a number, not nothing. Please participate.");
        continue;
    }

    try
    {
        int number = int.Parse(input);
        string romanNumeral = "";
        if (number < 1 || number > 100)
        {
            Console.WriteLine("Between 1 and 100, please. I believe in you. Try again.");
            continue;
        }
        
        if (number == 100)
        {
            Console.WriteLine("100 in Roman numerals is C.");
            bool restart = Restart();
            if (restart == false)
            {
                break;
            }
        }
        if (number >= 90)
        {
            romanNumeral += "XC";
            number -= 90;
        }
        if (number >= 50)
        {
            romanNumeral += "L";
            number -= 50;
        }
        if (number >= 40)
        {
            romanNumeral += "XL";
            number -= 40;
        }
        if (number >= 10)
        {
            while (number >= 10)
            {
                romanNumeral += "X";
                number -= 10;
            }
        }
        if (number == 9)
        {
            romanNumeral += "IX";
            number -= 9;
        }
        if (number >= 5)
        {
            romanNumeral += "V";
            number -= 5;
        }
        if (number == 4)
        {
            romanNumeral += "IV";
            number -= 4;
        }
        while (number >= 1)
        {
            romanNumeral += "I";
            number -= 1;
        }
        if (number == 0)
        {
            Console.WriteLine($"{input} in Roman numerals is {romanNumeral}.");
            bool restart = Restart();
            if (restart == false)
            {
                break;
            }
        }
        else
        {
            Console.WriteLine("Something went wrong. Please try again.");
            continue;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("That's not a valid number. Please enter a whole number between 1 and 100.");
        continue;
    }
}

bool Restart()
{
    Console.WriteLine("Want to try again? (y/n)");
    string? response = Console.ReadLine();
    if (response != null && response.ToLower() == "y") 
    {
        return true;
    }
    else 
    {
        Console.WriteLine("Thanks for playing! Goodbye.");
        return false;
    }
}