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

        private string countries;
        private List<CountriesTextFile> CountryList = new List<CountriesTextFile>();
        public string Countries
        {
            get
            {
                return countries;
            }

            set
            {
                countries = value;
            }
        }

        public static List<CountriesTextFile>ReadFile()
        {
            List<CountriesTextFile> CountryList = new List<CountriesTextFile>();//create a list to store countries

           // string [] fileLocation = new string []("../../countries.txt");//create a string from text file

           // fileLocation.Split('\n');//split each country string apart
            string line;
            string file = "../../countries.txt";
            StreamReader reader = new StreamReader(file);

            while (reader.EndOfStream==false)
            {
                line = reader.ReadLine();
                Console.WriteLine(line);
            }
            Console.ReadLine();
            reader.Close();
            
            

            ////reads text file
            //string textString = reader.ReadToEnd().Trim();//turns text into string
            // = textString.Split('\n');//splits string at each line, outs into array



            //Console.WriteLine($"Country: {textArray}");
            //reader.Close();

            //return textArray;

            return CountryList;
        }

        public static void WriteString(string countries)
        {
            StreamWriter wc = new StreamWriter("../../DataFile.txt", true);

            wc.Write($"\n: {countries}");

            wc.Close();
        }
     
        //public static void SaveToFile()

        //{
        //    StreamWriter cl = new StreamWriter("../../DataFile.txt", true);

        //    cl.WriteLine();

        //    cl.Dispose();
         
    }
}
