using System;
using System.IO;

namespace Lab03_SystemIO
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your tea cabinet!");
            GetList();
        }


        public static void GetList()
        {

            try
            {
                string path = @"Assets/TeaInventory.txt";
                string teaList = File.ReadAllText(path);
                Console.WriteLine(teaList);
            }
            catch (DirectoryNotFoundException dnf)
            {

                Console.WriteLine("Sorry, file not found {0}", dnf.Message);
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
