using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingWords
{
    class CountingWords
    {
       public static char[] ExtractSeparators(string text)
        {
            HashSet<char> separators = new HashSet<char>();

            foreach(char word in text)
            {
                if (!char.IsLetter(word))
                {
                    separators.Add(word);
                }
            }
            return separators.ToArray();
        }

        private static string[] ExtractWords(string text)
        {
            char[] separators = ExtractSeparators(text);
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }

        private static bool IsUpperCase(string word)
        {
            bool result = word.Equals(word.ToUpper());
            return result;
        }

        private static bool IsLowerCase(string word)
        {
            bool result = word.Equals(word.ToLower());
            return result;
        }

        public static void CountWords(string[] words)
        {
            int upperCase = 0;
            int lowerCase = 0;

            foreach(string word in words)
            {
                if (IsUpperCase(word))
                {
                    upperCase++;
                }
                if (IsLowerCase(word))
                {
                    lowerCase++;
                }
            }
            Console.WriteLine("Total words count: "+words.Count());
            Console.WriteLine("Lower Case: "+lowerCase);
            Console.WriteLine("Upper Case:"+upperCase);
        }

        public static string ReadText()
        {
            Console.WriteLine("Enter text:");
            return Console.ReadLine();
        }

        private static void Main()
        {
            string text = ReadText();
            string[] words = ExtractWords(text);
            CountWords(words);
            Console.ReadLine();
        }


    }
}
