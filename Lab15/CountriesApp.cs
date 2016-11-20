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
        // private string CountryArray;

        //private int menu;

        //public int Menu
        //{
        //    get
        //    {
        //        return menu;
        //    }

        //    set
        //    {
        //        menu = value;
        //    }
        //}
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Countries Maintenance App!");

            string agree = "y";

            while (agree == "y")
            {
                CountriesApp obj = new CountriesApp();
                Console.WriteLine("\n1 - See the list of Countries\n2 - Add a country\n3 - Exit");
                Console.WriteLine("Enter menu number");
                int Menu = int.Parse(Console.ReadLine());

                obj.menuMethod(Menu);
                Console.Write("Do you want to continue? (y/n): ");
                agree = Console.ReadLine().ToLower();
            }
            if (agree == "n")
                Console.WriteLine("Bye...");

        }

        public void menuMethod(int menu)
        {
            #region Menu
            switch (menu)
            {
                case 1:
                    CountriesTextFile.ReadFile();
                    break;

                case 2:

                    Console.WriteLine("Type a country: ");

                    string countries = Console.ReadLine();

                    CountriesTextFile.WriteString(countries);

                    break;

                default:

                    Console.WriteLine("Bye!");

                    break;
            }

            #endregion
        }
    }
}
