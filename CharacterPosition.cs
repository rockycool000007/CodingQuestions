using System;

namespace CodingQuestions
{
    public class CharacterPosition
    {
        static void Main()
        {
            Console.WriteLine("Enter a sentence");
            string sentence = Console.ReadLine();

            Console.WriteLine($"Enter a character to find in '{sentence}'");
            string character = Console.ReadLine();

            FindCharacterPosition(sentence, character);

            Console.Read();
        }

        private static void FindCharacterPosition(string sentence, string character)
        {
            int count = 0;
            int i = 0;

            while (i < sentence.Length)
            {
                if (sentence[i].ToString().Equals(character))
                {
                    Console.WriteLine($"'{character}' found at position '{i}'");
                    count++;
                }

                i++;
            }

            Console.WriteLine($"The character '{character}' occurred {count} times.");
        }
    }
}