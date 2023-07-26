namespace PracticeProblems
{
    public class ArrayProblems
    {
        public void DuplicateElements()
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            // Input array elements from the user
            Console.WriteLine($"Enter {size} elements:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int duplicateCount = 0;

            // Count the number of duplicate elements
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        duplicateCount++;
                        break;
                    }
                }
            }

            Console.WriteLine($"Total number of duplicate elements in the array: {duplicateCount}");
        }

        public void UniqueElements()
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            // Input array elements from the user
            Console.WriteLine($"Enter {size} elements:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Find and print unique elements
            Console.WriteLine("Unique elements in the array:");
            for (int i = 0; i < size; i++)
            {
                bool isUnique = true;

                // Check if the current element is unique
                for (int j = 0; j < size; j++)
                {
                    if (i != j && arr[i] == arr[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }

        public void CountFrequency()
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            // Input array elements from the user
            Console.WriteLine($"Enter {size} elements:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Array to mark visited elements
            bool[] visited = new bool[size];

            // Count the frequency of each element
            for (int i = 0; i < size; i++)
            {
                if (visited[i])
                    continue;

                int count = 1;
                for (int j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        visited[j] = true;
                    }
                }

                Console.WriteLine($"{arr[i]}: {count}");
            }
        }

        public void Max_Min()
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            // Input array elements from the user
            Console.WriteLine($"Enter {size} elements:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int maxElement = arr[0];
            int minElement = arr[0];

            // Find the maximum and minimum elements
            for (int i = 1; i < size; i++)
            {
                if (arr[i] > maxElement)
                {
                    maxElement = arr[i];
                }

                if (arr[i] < minElement)
                {
                    minElement = arr[i];
                }
            }

            Console.WriteLine("Maximum element: " + maxElement);
            Console.WriteLine("Minimum element: " + minElement);
        }

        public void SumofTwoLowestNo()
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            // Input array elements from the user
            Console.WriteLine($"Enter {size} elements:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int firstMin = int.MaxValue;
            int secondMin = int.MaxValue;

            // Find the two lowest numbers
            foreach (int num in arr)
            {
                if (num < firstMin)
                {
                    secondMin = firstMin;
                    firstMin = num;
                }
                else if (num < secondMin && num != firstMin)
                {
                    secondMin = num;
                }
            }

            int sum = firstMin + secondMin;

            Console.WriteLine("The two lowest numbers are: " + firstMin + " and " + secondMin);
            Console.WriteLine("Their sum is: " + sum);
        }
    }
}
