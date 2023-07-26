using PracticeProblems;

namespace PracticeProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practice Problems");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("\n 1. Duplicate Elements in array \n 2.Unique elements \n 3. Count Frequency " +
                "\n 4. Maximum & Minimum \n 5. Down Star Pattern \n 6. Box star Pattern \n 7. Reverse Word " +
                "\n 8. Sum of all digits \n 9. Convert Letter \n 10. Sum of two lowest no ");
            
            Console.WriteLine("Enter a Number: ");
            int num = int.Parse(Console.ReadLine());
            
            ArrayProblems A = new ArrayProblems();
            PatternProblems p = new PatternProblems();
            SomeProblems S = new SomeProblems();

            switch (num)
            {
                case 1:
                    A.DuplicateElements();
                        break;
                case 2:
                    A.UniqueElements();
                    break;
                
                case 3:
                    A.CountFrequency();
                    break; 
                
                case 4:
                    A.Max_Min();
                    break;
                    
                case 5:
                    p.DownPattern();
                    break;
                    
                case 6:
                    p.BoxPattern();
                    break;

                case 7:
                    S.ReverseWords();
                    break;

                case 8:
                    S.SumofDigits();
                    break;

                case 9:
                    S.ConvertLetter();
                    break;

                case 10:
                    A.SumofTwoLowestNo();
                    break;

                default: 
                    Console.WriteLine("Invalid Input");
                    break;
            }

        }
    }
}