using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> library = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Moroni", 10, 4, 5), "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost."),
            new Scripture(new Reference("Doctrine and Covenants", 6, 36), "Look unto me in every thought; doubt not, fear not."),
            new Scripture(new Reference("Moses", 1, 39), "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.")
        };

        Random random = new Random();
        int index = random.Next(library.Count);
        Scripture scripture = library[index];

        SessionTimer timer = new SessionTimer();
        timer.Start();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            
            if (scripture.IsCompletelyHidden())
            {
                timer.Stop();
                Console.WriteLine($"\nCongratulations! It took you {timer.GetTotalSeconds()} seconds to memorize this scripture.");
                break;
            }

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}

/* EXCEEDING REQUIREMENTS:
        SessionTimer Class: Added a simple custom class to track how many seconds it takes the user 
         to memorize the scripture, adding a gamification element to help with the memorization challenge.
         */