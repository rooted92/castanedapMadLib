//Pedro Castaneda
//10-17-2022
//Mad Lib
//Create a Mad Lib game where user will be asked to input different types of words that will be used to output a funny story.

bool run = true;

while(run)
{
    Console.WriteLine("It's Madlib!");
    Console.WriteLine("To create our story please follow the instructions below.");
    //Instructions
    Console.WriteLine("Provide 2 adjectives..");
    Console.WriteLine("Enter first adjective:");
    string adj1 = Console.ReadLine().ToLower();
    Console.WriteLine("Enter second adjective:");
    string adj2 = Console.ReadLine().ToLower();
    Console.WriteLine("Provide 5 nouns..");
    Console.WriteLine("Enter the name of a scary creature:");
    string noun1 = Console.ReadLine().ToLower();
    Console.WriteLine("Enter the name of a thing:");
    string noun2 = Console.ReadLine().ToLower();
    Console.WriteLine("Enter the name of a thing:");
    string noun3 = Console.ReadLine().ToLower();
    Console.WriteLine("Enter the name of a thing:");
    string noun4 = Console.ReadLine().ToLower();
    Console.WriteLine("Enter the name of a thing:");
    string noun5 = Console.ReadLine().ToLower();
    Console.WriteLine("Please provide 4 verbs..");
    Console.WriteLine("Enter a verb ending with 'ing':");
    string verb1 = Console.ReadLine().ToLower();
    Console.WriteLine("Enter a verb ending with 'ing':");
    string verb2 = Console.ReadLine().ToLower();
    Console.WriteLine("Enter a verb used in the past tense:");
    string verb3 = Console.ReadLine().ToLower();
    Console.WriteLine("Enter a verb ending with 'ing':");
    string verb4 = Console.ReadLine().ToLower();
    Console.WriteLine("Please provide 1 adverb:");
    Console.WriteLine("Enter an adverb with the suffix -ly:");
    string adverb = Console.ReadLine().ToLower();

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