using System;

namespace Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();

            int count = 0;

            foreach (string word in words)
            {
                for(int i = 0; i < word.Length; i++)
                {
                    if (word[i].ToString() == letter)
                    {
                        count += 1;
                        Console.WriteLine(word);
                        break; // only print the word once after finding one instance of letter
                    }
                }
            }

            if (count < 1)
            {
                Console.WriteLine("No match");
            }

        }
    }
}
