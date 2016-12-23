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
        private string country;
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public List<string> CountryList1
        {
            get
            {
                return CountryList;
            }

            set
            {
                CountryList = value;
            }
        }

        private List<string> CountryList;
        //string fileLocation = ("../../countries.txt"); 
        //foreach (var item in CountryList)
        //    {
        //        CountryList.Add();

        //    }


        public static List<string> ReadFile()
        {   
            string fileLocation = ("../../countries.txt");

            List<string> CountryList = new List<string>();

            using (StreamReader reader = new StreamReader(fileLocation, true))
            {
                //Ensure last line is read.
                while (reader.EndOfStream == false)
                {
                    string countries = reader.ReadToEnd().Trim();

                    //Strings are split by each new line.
                    string[] CountryArray = countries.Split('\n');

                    foreach (var country in CountryArray)
                    {
                       CountryList.Add(country);
                       Console.WriteLine(country);
                    }
                }
                return CountryList;
            }
        }

        public static void WriteString(string countries, List<string> CountryList)
        {
            //Get Countrylist from read method.
            ReadFile();

            //Add country to list.
            CountryList.Add("\n"+countries);

            //Open stream to file.
            StreamWriter writeToFile = new StreamWriter("../../countries.txt", true);


            foreach (string country in CountryList)

            {
                //Write each country to file.
                 writeToFile.Write(country);
            }

            //Close the I/O stream.
            writeToFile.Close();

            writeToFile.Dispose();
            //Return list to show user country has been added.
           
        }
        
    }
}
    