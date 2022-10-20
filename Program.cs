//Pedro Castaneda
//10-17-2022
//Mad Lib
//Create a Mad Lib game where user will be asked to input different types of words that will be used to output a funny story.
//TODO - see if you can put the validation for each word inside of a fucntion and just call the method instead of repeating the same code for each word

bool run = true;
string adj1 = "";
string adj2 = "";
string noun1 = "";
string noun2 = "";
string noun3 = "";
string noun4 = "";
string noun5 = "";
string verb1 = "";
string verb2 = "";
string verb3 = "";
string verb4 = "";
string adverb = "";
while(run)
{
    bool word1 = false;
    bool word2 = false;
    bool word3 = false;
    bool word4 = false;
    bool word5 = false;
    bool word6 = false;
    bool word7 = false;
    bool word8 = false;
    bool word9 = false;
    bool word10 = false;
    bool word11 = false;
    bool word12 = false;
    Console.WriteLine("It's Madlib!");
    Console.WriteLine("To create our story please follow the instructions below.");
    //Instructions
    Console.WriteLine("Provide 2 adjectives..");
    Console.WriteLine("Enter first adjective:");
    while(!word1)
    {
        adj1 = Console.ReadLine().ToLower();
        bool isWord1 = adj1.All(Char.IsLetter);
        if(isWord1 == false || string.IsNullOrEmpty(adj1))
        {
            Console.WriteLine("Please enter a word!");
            word1 = false;
        }
        else
        {
            word1 = true;
        }
    }
    Console.WriteLine("Enter second adjective:");
    while(!word2)
    {
        adj2 = Console.ReadLine().ToLower();
        bool isWord2 = adj2.All(Char.IsLetter);
        if(isWord2 == false || string.IsNullOrEmpty(adj2))
        {
            Console.WriteLine("Please enter a word!");
            word2 = false;
        }
        else
        {
            word2 = true;
        }
    }
    Console.WriteLine("Provide 5 nouns..");
    Console.WriteLine("Enter the name of a scary creature:");
    while(!word3)
    {
        noun1 = Console.ReadLine().ToLower();
        bool isWord3 = noun1.All(Char.IsLetter);
        if(isWord3 == false || string.IsNullOrEmpty(noun1))
        {
            Console.WriteLine("Please enter a word!");
            word3 = false;
        }
        else
        {
            word3 = true;
        }
    }
    Console.WriteLine("Enter the name of a thing:");
    while(!word4)
    {
        noun2 = Console.ReadLine().ToLower();
        bool isWord4 = noun2.All(Char.IsLetter);
        if(isWord4 == false || string.IsNullOrEmpty(noun2))
        {
            Console.WriteLine("Please enter a word!");
            word4 = false;
        }
        else
        {
            word4 = true;
        }
    }
    Console.WriteLine("Enter the name of a thing:");
    while(!word5)
    {
        noun3 = Console.ReadLine().ToLower();
        bool isWord5 = noun3.All(Char.IsLetter);
        if(isWord5 == false || string.IsNullOrEmpty(noun3))
        {
            Console.WriteLine("Please enter a word!");
            word5 = false;
        }
        else
        {
            word5 = true;
        }
    }
    Console.WriteLine("Enter the name of a thing:");
    while(!word6)
    {
        noun4 = Console.ReadLine().ToLower();
        bool isWord6 = noun4.All(Char.IsLetter);
        if(isWord6 == false || string.IsNullOrEmpty(noun4))
        {
            Console.WriteLine("Please enter a word!");
            word6 = false;
        }
        else
        {
            word6 = true;
        }
    }
    Console.WriteLine("Enter the name of a thing:");
    noun5 = Console.ReadLine().ToLower();
    while(!word7)
    {
        noun5 = Console.ReadLine().ToLower();
        bool isWord7 = noun5.All(Char.IsLetter);
        if(isWord7 == false || string.IsNullOrEmpty(noun5))
        {
            Console.WriteLine("Please enter a word!");
            word7 = false;
        }
        else
        {
            word7 = true;
        }
    }
    Console.WriteLine("Please provide 4 verbs..");
    Console.WriteLine("Enter a verb ending with 'ing':");
    while(!word8)
    {
        verb1 = Console.ReadLine().ToLower();
        bool isWord8 = verb1.All(Char.IsLetter);
        if(isWord8 == false || string.IsNullOrEmpty(verb1))
        {
            Console.WriteLine("Please enter a word!");
            word8 = false;
        }
        else
        {
            word8 = true;
        }
    }
    Console.WriteLine("Enter a verb ending with 'ing':");
    while(!word9)
    {
        verb2 = Console.ReadLine().ToLower();
        bool isWord9 = verb2.All(Char.IsLetter);
        if(isWord9 == false || string.IsNullOrEmpty(verb2))
        {
            Console.WriteLine("Please enter a word!");
            word9 = false;
        }
        else
        {
            word9 = true;
        }
    }
    Console.WriteLine("Enter a verb used in the past tense:");
    while(!word10)
    {
        verb3 = Console.ReadLine().ToLower();
        bool isWord10 = verb3.All(Char.IsLetter);
        if(isWord10 == false || string.IsNullOrEmpty(verb3))
        {
            Console.WriteLine("Please enter a word!");
            word10 = false;
        }
        else
        {
            word10 = true;
        }
    }
    Console.WriteLine("Enter a verb ending with 'ing':");
    verb4 = Console.ReadLine().ToLower();
    while(!word11)
    {
        verb4 = Console.ReadLine().ToLower();
        bool isWord11 = verb4.All(Char.IsLetter);
        if(isWord11 == false || string.IsNullOrEmpty(verb4))
        {
            Console.WriteLine("Please enter a word!");
            word11 = false;
        }
        else
        {
            word11 = true;
        }
    }
    Console.WriteLine("Please provide 1 adverb:");
    Console.WriteLine("Enter an adverb with the suffix -ly:");
    adverb = Console.ReadLine().ToLower();
    while(!word12)
    {
        adverb = Console.ReadLine().ToLower();
        bool isWord12 = adverb.All(Char.IsLetter);
        if(isWord12 == false || string.IsNullOrEmpty(adverb))
        {
            Console.WriteLine("Please enter a word!");
            word12 = false;
        }
        else
        {
            word12 = true;
        }
    }

    Console.WriteLine("");
    Console.WriteLine("Here is your award winning story!!!");
    Console.WriteLine("");

    //Displays the Madlib story to the user
    Console.WriteLine($"Once upon a time there was a {adj1} {noun1} who liked {verb1} trees.");
    Console.Write($"After a long day from {verb2}, it sat down and took off it's {noun2}.");
    Console.Write($"It {adverb} {verb3} over to the kitchen to grab a {noun3} from the fridge,");
    Console.Write($" tripped over a {noun4} and hit its head on the corner of the {noun5}. ");
    Console.Write($"It never went back to {verb4} ever again because it was {adj2}. THE END.");

    Console.WriteLine("");
    playAgain();

}

void playAgain()
{
    bool replay = true;
    while(replay)
    {
        Console.WriteLine("Would you like to play again? (yes/no)");
        string userInput = Console.ReadLine().ToLower();
        if(userInput == "yes" || userInput == "y")
        {
            replay = false;
            run = true;
        }
        else if(userInput == "no" || userInput == "n")
        {
            replay = false;
            run = false;
        }
        else
        {
            Console.WriteLine("Please enter yes or no");
            replay = true;
        }
    }
}