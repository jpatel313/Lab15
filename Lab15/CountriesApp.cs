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
        private string input;

        public void menuMethod(int menu)
        {
            switch (menu)
            {
                case 1:
                    
                    List<CountriesTextFile> CTFList = CountriesTextFile.ReadFile();
                    
                    foreach (CountriesTextFile country in CTFList)
                    {

                        Console.WriteLine($"Countries:\n{country}");
                    }

                    break;

                case 2:
                    CountriesTextFile.WriteFile(input);
                    
                    break;

                default:

                    Console.WriteLine("See-ya!");
                    break;
            }
        }
    }
}
