using System;
using System.IO;

namespace Lab03_SystemIO
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your tea cabinet!");

            string teaList = GetList("Assets/TeaInventory.txt");
            Console.WriteLine(teaList);

            TeaControls();
        }


        public static string GetList(string path)
        {

            try
            {
                //path = @"Assets/GetList_TeaInventory.txt";
                string teaList = File.ReadAllText(path);
                return teaList;
            }
            catch (DirectoryNotFoundException dnf)
            {

                Console.WriteLine("Sorry, file not found {0}", dnf.Message);
                return " ";
            }

        }
        public static void TeaControls()
        {
            string[] userActionSelection =
            {
                    "1. View Tea Inventory",
                    "2. Add Tea to Inventory",
                    "3. Delete Tea from Inventory",
                    "4. Exit Tea Inventory"
                };
            Console.WriteLine("Welcomee to your tea inventory, please choose a number to proceed");
            foreach (string action in userActionSelection)
            {
                Console.WriteLine(action);
            }
            try
            {
                //userChoice goes here
                UserChoice();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Sorry something was wrong, please return at a later date {0}", ex.Message);
            }

        }
        public static void UserChoice()
        {
            string userInput = Console.ReadLine();
            //if user inputs
            if (userInput == "1" || userInput == "one")
            {
                Console.WriteLine("Test: Returns Tea Inventory");
            }
            else if(userInput == "2" || userInput == "two")
            {
                Console.WriteLine("Test: returns what you added to tea inventory");
            }
            else if (userInput == "3" || userInput == "three")
            {
                Console.WriteLine("Test: returns what you deleted tea inventory");
            }
            else if (userInput == "4" || userInput == "four")
            {
                Console.WriteLine("Test: exits program");
            }
            else
            {
                throw new Exception("Sorry that is not a valid input");
            }

        }

        public static void RemoveTea(string path, string teaToRemove)
        {
            string[] existingLines = File.ReadAllLines(path);

            string[] result = RemoveItemFromArray(existingLines, teaToRemove);

            File.WriteAllLines(path, result);
        }

        public static string[] RemoveItemFromArray(string[] array, string teaToRemove)
        {
            int valueCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == teaToRemove)
                {
                    valueCount++;
                }
            }
            string[] result = new string[array.Length - valueCount];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] != teaToRemove)
                {
                    result[j++] = array[i];
                }
            }
            return array;
        }
    }
}
