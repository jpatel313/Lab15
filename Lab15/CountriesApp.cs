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
        public void menuMethod(int menu)
        {

            switch (menu)
            {
                case 1:
                    
                    List<CountriesTextFile> CTFList = CountriesTextFile.ReadFile();
                    
                    foreach (CountriesTextFile country in CTFList)
                    {

                        Console.WriteLine($"\n{country}");
                    }

                    break;

                case 2:

                    Console.WriteLine("Type a country: ");
                    string countries = Console.ReadLine();

                    CountriesTextFile.WriteFile(countries);
                    
                    break;

                default:

                    Console.WriteLine("Bye!");
                    
                    //Program.Continue();
                    break;
            }
        }
    }
}
