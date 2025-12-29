using System;
using System.Text;
/*    
<summary>

Processes poorly formatted text input from users and automatically corrects common formatting issues by
ensuring proper spacing after punctuation marks, capitalizing the first letter of each sentence, and 
removing unnecessary extra spaces from the paragraph.

</summary>
*/

namespace BridgeLabzTraining.scenario_based
{
    internal class SentenceFormatter
    {
        // This method is used to format the input paragraph in accordance with the question
        public static string Formatter(string rawString)
        {
            if (rawString == null || rawString.Length == 0)
                return rawString;

            StringBuilder finalString = new StringBuilder();
            bool capitalFlag = true;

            for (int i = 0; i < rawString.Length; i++)
            {
                char curr = rawString[i];
                
                // This is used to skip extra spaces
                if (curr == ' ')
                {
                    if (finalString.Length == 0 || finalString[finalString.Length - 1] == ' ')
                    {
                        continue;
                    }
                }

                // This is used to change character from lowercase to uppercase and vice-versa
                if (capitalFlag && rawString[i] >= 'a' && rawString[i] <= 'z')
                {
                    curr = ((char)(rawString[i] - 32));
                }
                else if (curr >= 'A' && curr <= 'Z')
                {
                    curr = (char)(curr + 32);
                    capitalFlag = false;
                }

                // Character is appended here
                finalString.Append(curr);

                // Space is added if there is none after punctuations
                if (curr == '.' || curr == '?' || curr == '!')
                {
                    capitalFlag = true;

                    if (i < rawString.Length - 1 && rawString[i + 1] != ' ')
                    {
                        finalString.Append(' ');
                    }
                }
            }
            return finalString.ToString();
        }

        //Method to call the formatter
        public static void Caller() 
        {
            Console.WriteLine("Enter a paragraph below :");
            Console.WriteLine();
            string rawParagraph = Console.ReadLine();
            string finalParagraph = Formatter(rawParagraph);
            Console.WriteLine("Formatted paragraph below :");
            Console.WriteLine();
            Console.WriteLine(finalParagraph);
        }
    }
}
