using System;
using System.Text;
/*
    This program analyzes a given paragraph of text by counting the total number of words, identifying
    and displaying the longest word, and replacing all occurrences of a specified word with another word
    in a case-insensitive manner. It also safely handles edge cases such as empty input or paragraphs
    containing only whitespace to ensure reliable and accurate text processing.
*/
namespace BridgeLabzTraining.scenario_based
{
    internal class ParagraphStats
    {

        public static void ParaStats(string paragraph)
        {
            Console.WriteLine("Menu : ");
            Console.WriteLine();
            Console.WriteLine("Select one of the options below : ");
            Console.WriteLine();
            Console.WriteLine("1.Count the number of words in the paragraph.");
            Console.WriteLine("2.Find and display the longest word.");
            Console.WriteLine("3.Replace all occurrences of a specific word with another word (case-insensitive).");
            Console.WriteLine("4.All of the above.");
            Console.WriteLine();
            Console.Write("Give your choice (1/2/3/4): ");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.Write("Words count in the para : ");
                    Console.WriteLine(WordCount(paragraph));
                    break;

                case 2:
                    Console.Write("Longest word in the para : ");
                    Console.WriteLine(LongestWord(paragraph));
                    break;

                case 3:
                    Console.Write("Enter word to be replaced : ");
                    string word = Console.ReadLine();

                    Console.Write("Enter word to replace : ");
                    string replace = Console.ReadLine();

                    Console.WriteLine($"Para after replacing <{word}> with <{replace}> : ");
                    Console.WriteLine(ReplaceWords(paragraph, replace, word));
                    break;

                case 4:
                    Console.Write("Words count in the para : ");
                    Console.WriteLine(WordCount(paragraph));
                    Console.WriteLine();

                    Console.Write("Longest word in the para : ");
                    Console.WriteLine(LongestWord(paragraph));
                    Console.WriteLine();

                    Console.Write("Enter word to be replaced : ");
                    string word2 = Console.ReadLine();

                    Console.Write("Enter word to replace : ");
                    string replace2 = Console.ReadLine();

                    Console.WriteLine($"Para after replacing <{word2}> with <{replace2}> : ");
                    Console.WriteLine(ReplaceWords(paragraph, replace2, word2));
                    break;
            }
        }

        public static string ReplaceWords(string paragraph, string replace, string word)
        {
            StringBuilder modifiedParagraph = new StringBuilder();
            StringBuilder w = new StringBuilder();
            foreach(char ch in paragraph.ToCharArray())
            {
                if (ch == ' ')
                {
                    if (w.ToString().ToLower() == word.ToLower())
                        modifiedParagraph.Append(replace);
                    else
                    {
                        modifiedParagraph.Append(w);
                    }
                    modifiedParagraph.Append(' ');
                    w.Clear();
                }
                else
                {
                    w.Append(ch);
                }
            }

            if (w.Length > 0)
            {
                if (w.ToString().ToLower() == word.ToLower())
                    modifiedParagraph.Append(replace);
                else
                    modifiedParagraph.Append(w.ToString());
            }

            return modifiedParagraph.ToString();
        }
        
        public static int WordCount(string paragraph)
        {
            int count = 0;
            bool inWord = false;
            foreach(char ch in paragraph.ToCharArray())
            {
                if (ch != ' ')
                {
                    if (!inWord)
                    {
                        count++;
                        inWord = true;
                    }
                }
                else
                {
                    inWord = false;
                }
                
            }
            return count;
        }

        public static string LongestWord(string paragraph)
        {
            int len = 0;
            string longest = "";
            StringBuilder temp = new StringBuilder();
            foreach (char ch in paragraph.ToCharArray())
            {
                if (ch == ' ' || ch == '.')
                {
                    if(temp.Length > len)
                    {
                        longest = temp.ToString();
                        len = temp.Length;
                    }
                    temp.Clear();

                }
                else
                    temp.Append(ch);
            }
            if (temp.Length > len)
                longest = temp.ToString();
            
            return longest;
        }

        public static void Caller()
        {
            Console.WriteLine("Enter a paragraph below :");
            Console.WriteLine();
            string paragraph = Console.ReadLine();

            if (paragraph == null || paragraph.Length == 0)
            {
                Console.WriteLine("Enter valid paragraph");
                return;
            }

            Console.WriteLine("Paragraph stats below :");
            Console.WriteLine();
            ParaStats(paragraph);
            
        }
    }
}
