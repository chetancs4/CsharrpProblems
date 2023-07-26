using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class PatternProblems
    {
        public void DownPattern() 
        {
            Console.Write("Enter the number of rows in the pattern: ");
            int rows = int.Parse(Console.ReadLine());

            // Print the down star pattern
            for (int i = rows; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public void BoxPattern() 
        {
            Console.Write("Enter the number of rows in the pattern: ");
            int rows = int.Parse(Console.ReadLine());

            // Print the box star pattern
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows; j++)
                {
                    if (i == 1 || i == rows || j == 1 || j == rows)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
        }
    }
}
