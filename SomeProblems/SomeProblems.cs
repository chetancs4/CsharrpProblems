using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class SomeProblems
    {
        public void ReverseWords()
        {
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            //string reversedString = ReverseWords(inputString);

            Console.WriteLine("Reversed String: ");

            string[] words = inputString.Split(' '); // Split the input string into individual words

            for (int i = 0; i < words.Length; i++)
            {
                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray); // Reverse each word
                words[i] = new string(charArray);
            }

            Console.WriteLine(string.Join(" ", words));
        }

        public void SumofDigits()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            // Find sum of digits
            while (number != 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }

            Console.WriteLine("Sum of all digits: " + sum);
        }

        public void ConvertLetter()
        {
            Console.Write("Enter a sentence: ");
            string inputSentence = Console.ReadLine();

            char[] charArray = inputSentence.ToCharArray();

            // Convert the first letter of each word to capital
            for (int i = 0; i < charArray.Length; i++)
            {
                if (i == 0 || charArray[i - 1] == ' ')
                {
                    if (char.IsLower(charArray[i]))
                    {
                        charArray[i] = char.ToUpper(charArray[i]);
                    }
                }
                else
                {
                    if (char.IsUpper(charArray[i]))
                    {
                        charArray[i] = char.ToLower(charArray[i]);
                    }
                }
            }

            string resultSentence = new string(charArray);
            Console.WriteLine("Converted sentence: " + resultSentence);
        }

       
    }
}
