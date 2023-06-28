using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] lotsOfNumbers = new int[50];
            //variableType[] variableName = new variableType[#] 

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            //Populater(lotsOfNumbers);

            //TODO: Print the first number of the array
            Console.WriteLine(lotsOfNumbers[0]);
            //TODO: Print the last number of the array            
            Console.WriteLine(lotsOfNumbers[lotsOfNumbers.Length - 1]);
            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            Populater(lotsOfNumbers);
            NumberPrinter(lotsOfNumbers);
            Console.WriteLine("-------------------");
            
            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            
            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(lotsOfNumbers);
            NumberPrinter(lotsOfNumbers);
            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(lotsOfNumbers);
            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(lotsOfNumbers);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            Array.Sort(lotsOfNumbers);
            for (int i = 0; i < lotsOfNumbers.Length; i++)
            {
                Console.WriteLine(lotsOfNumbers[i]);
            }
            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            List<int> myList = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine(myList.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(myList);

            //TODO: Print the new capacity
            NumberPrinter(myList);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
                        
            var input = int.TryParse(Console.ReadLine(), out int res);
            while (!input)
            {
                Console.WriteLine("That's not a number. Try again...");
                input = int.TryParse(Console.ReadLine(), out int res2);
                res = res2;
            }
            NumberChecker(myList, res);   
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(myList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(myList);
            Console.WriteLine("------------------");

            // Little Extra --------------
            //TODO: Sort the list then print results
            Console.WriteLine("Reverse Sorted Evens!!");            
            myList.Sort();
            OddKiller(myList);
            Console.WriteLine("------------------");
            // ---------------------------

            Console.WriteLine("Sorted Evens!!");
            myList.Sort();
            myList.Reverse();
            OddKiller(myList);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var storedListAsArray = myList.ToArray();

            //TODO: Clear the list
            myList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                    Console.WriteLine(numbers[i]);
                }
                else
                {
                    numbers[i] = numbers[i];
                    Console.WriteLine(numbers[i]);
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count - 1; i > 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(i);
                }
                else
                {
                    Console.WriteLine(numberList[i]);
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {            
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"This List Contains The Number: \n{searchNumber}");
            }
            else
            {
                Console.WriteLine($"This List Does Not Contain The Number: \n{searchNumber}");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int currentIndext = 0; currentIndext < 50; currentIndext++)
            {
                numberList.Add(rng.Next(0, 51));
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int currentIndex = 0; currentIndex < 50; currentIndex++)
            {
                numbers[currentIndex] = rng.Next(0, 51);
            }
        }        

        private static void ReverseArray(int[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                Console.WriteLine(array[i]);
            }
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
