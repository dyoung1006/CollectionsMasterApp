using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        //somecomment
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] ints = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(ints);

            //TODO: Print the first number of the array
            Console.WriteLine($"{ints.FirstOrDefault()}");
            //TODO: Print the last number of the array            
            Console.WriteLine($"{ints.LastOrDefault()}");

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(ints);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            Array.Reverse(ints);

            Console.WriteLine("---------REVERSE CUSTOM------------");

            NumberPrinter(ints);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers

            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(ints);


            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(ints);
            NumberPrinter(ints);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            List<int> lstints = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine(lstints.Capacity.ToString());

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            lstints.Capacity = 50;
            Populater(lstints);

            //TODO: Print the new capacity
            Console.WriteLine(lstints.Capacity.ToString());

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!


            int userNumber;

            while (true)
            {
                Console.WriteLine("What number will you search for in the number list?");
                if (int.TryParse(Console.ReadLine(), out userNumber))
                {
                    break;
                }
                Console.WriteLine("Pleae enter a number");
            }

            Console.WriteLine(lstints.Contains(userNumber) ? "Your number is in the list" : "Your number is not in the list");

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(lstints);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(lstints);
            lstints.TrimExcess();

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            lstints.Sort();
            NumberPrinter(lstints);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var convertedListToArray = lstints.ToArray();

            //TODO: Clear the list
            lstints.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            StringBuilder listOfNumbers = new StringBuilder();

            IEnumerable<int> uniqueNumbers = numbers.Distinct<int>();
            int count = 1;
            int totalnumbers = uniqueNumbers.Count();

            if (uniqueNumbers.Contains(0))
                totalnumbers--;

            foreach (int number in uniqueNumbers)
            {
                if (number % 3 == 0)
                {
                    if (number != 0)
                    {
                        listOfNumbers.Append((count < totalnumbers) ? $"{number.ToString()}, " : $"{number.ToString()}");
                    }
                }
                count++;
            }
            Console.Write(listOfNumbers);
            Console.WriteLine(Environment.NewLine);
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
            }

            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {

        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int count = 0; count < numberList.Capacity; count++)
            {
                numberList.Add(rng.Next(50));
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int count = 0; count < numbers.Length; count++)
            {
                numbers[count] = rng.Next(50);
            }
        }

        private static void ReverseArray(int[] array)
        {

        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
