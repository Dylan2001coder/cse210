using System;

namespace DailyScripture
{
    class Program
    {
        
        static void Main()
        {
            Scripture scripture = new Scripture("Alma 48 ", 13, 17, "Yea, and he was a man who was firm in the faith of Christ, and he had sworn with an oath to defend his people, his rights, and his country, and his religion, even to the loss of his blood. Yea, verily, verily I say unto you, if all men had been, and were, and ever would be, like unto Moroni, behold, the very powers of hell would have been shaken forever; yea, the devil would never have power over the hearts of the children of men. ");
            Console.Clear();
            scripture.Display(); 
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;

                if (!scripture.HideRandomWord())
                {
                    Console.WriteLine("\nYou got this, you memorized the scripture!!");
                    break;
                }

                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            }
        }
    }
}