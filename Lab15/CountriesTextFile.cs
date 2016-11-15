using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab15
{
    public class CountriesTextFile
    {
        #region Properties
        private string Countries;
        //private string input;
        public string Countries1
        {
            get
            {
                return Countries;
            }

            set
            {
                Countries = value;
            }
        }

        //public string Input
        //{
        //    get
        //    {
        //        return input;
        //    }

        //    set
        //    {
        //        input = value;
        //    }
        //}
        #endregion

        //public CountriesTextFile()
        //{
        //    Countries = countries;
        //}

        //Method to read countries.txt file
        public static List<CountriesTextFile> ReadFile()
        {
            List<CountriesTextFile> CountryList = new List<CountriesTextFile>();
            string fileLocation = "../../countries.txt";

            StreamReader reader = new StreamReader(fileLocation);

            string data = reader.ReadToEnd().Trim();

            string[] Records = data.Split('\n');

            reader.Close();
            return CountryList;

        }

        public static void WriteFile(string input)
        {
            StreamWriter wc = new StreamWriter("../../DataFile.txt", true);
            Console.WriteLine("Type the name of the country to be added:");

            input = Console.ReadLine();

            wc.Write($"\n{input}");
            wc.Close();
        }
    }
}
