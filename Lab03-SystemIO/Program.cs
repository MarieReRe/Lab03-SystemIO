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
            /*public static void TeaControls()
            {
                string[] userActionSelection =
                {
                    "1. View Tea Inventory",
                }*/
        }


    }
}
