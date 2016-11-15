using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab15
{
    class Program
    {
        public static void Main(string[] args)

        {


            Console.WriteLine("Welcome to the Countries Maintenance App!");

            bool agree = Continue();
            while (agree)
            {
                //Menu
                Console.WriteLine("\n1 - See the list of Countries\n2 - Add a country\n3 - Exit");
                Console.WriteLine("Enter menu number");
                int menu = int.Parse(Console.ReadLine());

                //Call countries app for menu options
                CountriesApp display = new CountriesApp();
                display.menuMethod(menu);
            }


        }

        private static bool Continue()
        {
            return true;
        }

        //display.menuMethod( menu);
    }

 }
