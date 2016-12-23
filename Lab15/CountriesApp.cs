using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab15
{
    public class CountriesApp
    {
        public static void Main(string[] args)

        {
           
            List<string> CountryList = new List<string>();
            Console.WriteLine("Welcome to the Countries Maintenance App!");

            bool agree = true;
            while (agree)
            {

                Console.WriteLine("\n1. See the list of Countries\n2. Add a country\n3. Exit");
                Console.Write("Enter menu number:");
                int menu = int.Parse(Console.ReadLine());

                //Options Menu.
                switch (menu)
                {

                    case 1:

                        CountriesTextFile.ReadFile();
                        
                        break;
                        
                    case 2:

                        Console.WriteLine("Type a country: ");

                        string countries = Console.ReadLine();

                        CountriesTextFile.WriteString(countries, CountryList);
                       
                        break;

                    default:

                        Console.WriteLine("Goodbye!");

                        break;
                }

                Console.WriteLine("Return to main menu?");
                
                string decision = (Console.ReadLine()).ToLower();

                if (decision == "y" || decision == "yes" && Console.ReadLine() != null)
                {
                    Console.Clear();
                    agree = true;
                }

                else agree = false;
            }
        }
    }
}





