using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Done: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //Done: Create an integer Array of size 50
            int[] exerciseArrayOfSize50 = new int[50];


            //Done: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            // Generates a number between 1 to 50
            Random randomGenerator = new Random(); 
            
            for (int i = 0; i < 50; i++)
            {
                int randomNumber = randomGenerator.Next(1, 50);

                exerciseArrayOfSize50[i] = randomNumber;
            }


            //Done: Print the first number of the array

            Console.WriteLine(exerciseArrayOfSize50[0]);

            // Done: Print the last number of the array            
            Console.WriteLine(exerciseArrayOfSize50[49]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(exerciseArrayOfSize50);
            Console.WriteLine("-------------------");

            //Done: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            for (int i = 49; i >= 0; i--)
            {
                Console.WriteLine(exerciseArrayOfSize50[i]);
            }    

            Console.WriteLine("---------REVERSE CUSTOM------------");

            ReverseArray(exerciseArrayOfSize50);

            Console.WriteLine("-------------------");

            //Done: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            ThreeKiller(exerciseArrayOfSize50);

            Console.WriteLine("-------------------");

            //Done: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            
            Array.Sort(exerciseArrayOfSize50);
            foreach (int i in exerciseArrayOfSize50)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /* Set Up */
            // Done: Create an integer List

            List<int> randomNumberList = new List<int>();


            //Done: Print the capacity of the list to the console
            Console.WriteLine(randomNumberList.Count);
            Console.WriteLine(randomNumberList.Capacity);
            Console.WriteLine("look above");

            //Done: Populate the List with 50 random numbers between 0 and 50 you will need a method for this
                        
            Random randomNumGenerator = new Random(); 

            for (int i = 0; i < 70; i++)
            {
                int randomNumber = randomNumGenerator.Next(1, 50);

                 //not a good way to do this
                 //listName<int>( i ) = randomNumber;
                 //randomNumberList[i] = randomNumber;


               randomNumberList.Add(randomNumber);

            }


            //Done: Print the new capacity
            Console.WriteLine("new list capacity");
            Console.WriteLine(randomNumberList.Capacity);
            Console.WriteLine($"The count of the list is {randomNumberList.Count}");



            Console.WriteLine("---------------------");

            //Done: Create a method that prints if a user number is present in the list
            //Done: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");

            IsNumberPresent("55", randomNumberList);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");

            //Done this method to print out your numbers from arrays or lists
            NumberPrinter(randomNumberList);
            
            Console.WriteLine("-------------------");


            //Done: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            OddKiller(randomNumberList);


            Console.WriteLine("------------------");

            //Done: Sort the list then print results
            
            Console.WriteLine("Sorted Evens!!");

            OddKiller(randomNumberList);

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable


            //string[] str = myList.ToArray();
            int[] listConvertedToArray = randomNumberList.ToArray();

            foreach(int i in listConvertedToArray) 
            {
                Console.WriteLine(i); 
            }

            //TODO: Clear the list

            randomNumberList.Clear();


            #endregion
        }
        #region Private Methods
        private static void ThreeKiller(int[] exerciseArrayOfSize50)
        {
            foreach (int number in exerciseArrayOfSize50)
            {
                if (number % 3 == 0)
                {
                    Console.WriteLine(number);
                }

            }
        }
        
        

        private static void OddKiller(List<int> randomNumberList)
        {
            foreach (int number in randomNumberList.ToList())
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
                else
                {
                    randomNumberList.Remove(number);
                }

            }
            randomNumberList.Sort();

            foreach (int item in randomNumberList)
            { Console.WriteLine(item); }
        }

        /// <summary>
        /// Returns a bool value 
        /// see https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.contains?view=net-7.0 
        /// for details
        /// </summary>
        /// <param name="userInput"></param>
        /// <param name="randomNumberList"></param>
        /// <returns> bool </returns>
        private static bool IsNumberPresent (string userInput, List<int> randomNumberList)
        {
            bool isPresent = false;

            // psuedo code if user types in something other than an integer then print to console is not valid input

            int convertedNumber;
            if (Int32.TryParse(userInput, out convertedNumber))
            {
                Console.WriteLine($"the converted value is {convertedNumber}");
                isPresent = randomNumberList.Contains(convertedNumber);
            }
            else 
            {
                Console.WriteLine($"{userInput} not a valid number");
            }
            
            return isPresent;

            
        }
        private static void NumberChecker(List<int> numberList, int searchNumber)
        {

        }

        private static void Populater(List<int> numberList)
        {
            Random randomGenerator = new Random();    // Generates a number between 1 to 50

            int[] rndArray = new int[50];

            for (int i = 0; i < 50; i++)
            {
                int randomNumber = randomGenerator.Next(1, 50);
                rndArray[i] = randomNumber;
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

        }

        private static void ReverseArray(int[] array)
        {
            for (int i = 49; i >= 0; i--)
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
        #endregion

    }
}
