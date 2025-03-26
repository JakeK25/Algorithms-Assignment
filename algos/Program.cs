// Description of Implementation:
// Program name: Stock analysis
// Author: Jake Keightley 28997203
// Submission date: 27/03/25

// Description:
// - This program sorts and searches through 3 different text files which are share exchange tables.
// - This program will use a bubble sorting algorithm and a linear search algorithm to provide that functionality
// - to the user.

// Main Functions:
// - The main functions of this program are to sort and search through 3 text files including 256 numbers.
// - Bubble sort algorithm needs to be implemented, as well as linear search algorithm.

// Input Parameters:
// - Share files need to be placed in the debug file.
// - The share files given include 256 numbers gathered from the stock exchange.
// - These numbers will be converted into multiple arrays and the searching and sorting will occur using these arrays.

// Expected Output:
// - Searching is supposed to output true or false, showing whether the users number is within the specified file.
// - Sorting is supposed to sort the numbers in ascending order and display every 10th value.

// Number of sorting and searching algorithms implemented:
// - 2 (linear search and bubble sort)

namespace Algos
{
    public class Program
    {
        static bool Search(int[] array, int target)      // Search function
        {
            bool found = false;
            foreach (int i in array)
            {
                if (i == target)         // If it is the correct value return true
                {                        // If not found return false
                    found = true;
                }
            }
            return found;
        }
        static void TenthValues(int[] values)      // Function to display every 10th value
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(values[i]);
                }
            }
        }

        static int[] BubbleSort(int[] a)           // Create Bubblesorting Algorithm
        {
            int temp = 0;                          // Temp variable for swapping
            
            for (int pass = 0; pass <= a.Length - 2; pass++)   // Passes
            {
                for (int i = 0; i <= a.Length - 2; i++)    // Loop for swapping
                {
                    if (a[i] > a[i + 1])                  // Checking if current value is larger than next value
                    { 
                        temp = a[i + 1];
                        a[i + 1] = a[i];               // Swapping to get the correct order
                        a[i] = temp;
                    }
                }
            }
            return a;
        }

        public static void Main(string[] args)
        {
            string[] s1256 = System.IO.File.ReadAllLines("Share_1_256.txt");
            string[] s2256 = System.IO.File.ReadAllLines("Share_2_256.txt"); // Import Files
            string[] s3256 = System.IO.File.ReadAllLines("Share_3_256.txt");

            int[] a = s1256.Select(x => int.Parse(x)).ToArray();
            int[] b = s2256.Select(x => int.Parse(x)).ToArray(); // Convert list to an array of numbers
            int[] c = s3256.Select(x => int.Parse(x)).ToArray();

            a = BubbleSort(a);
            b = BubbleSort(b); // Bubble sort each array
            c = BubbleSort(c);
            int[] arr;
            do
            {
                Console.WriteLine("Search(1) or list sorted(2)");           // User choice for searching or sorting
                int choice = Int16.Parse(Console.ReadLine());
                if (choice == 2)
                {
                    Console.WriteLine("Which array to sort? 1,2,3");       // User choice of which array to sort
                    choice = Int16.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            arr = a;
                            break;
                        case 2:
                            arr = b;
                            break;
                        case 3:
                            arr = c;
                            break;
                        default:
                            arr = new int[1];
                            break;
                    }

                    TenthValues(arr);
                }
                else
                {
                    Console.WriteLine("Which array to search? 1, 2, 3");    // User choice for which array to search
                    choice = Int16.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            arr = a;
                            break;
                        case 2:
                            arr = b;
                            break;
                        case 3:
                            arr = c;
                            break;
                        default:
                            arr = new int[1];
                            break;
                    }

                    Console.WriteLine("Search term?");                   // Number to search for
                    int searchterm = Int16.Parse(Console.ReadLine());
                    Console.WriteLine(Search(arr, searchterm));
                }

            } while (true);


        }
    }
}