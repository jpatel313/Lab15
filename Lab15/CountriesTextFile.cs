using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab15
{
    class CountriesTextFile
    {
        #region Properties
        static string Countries;

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
        #endregion

        public 
            (string Countries)
        {
            this.Countries = Countries1;
        }

        private static List<CountriesTextFile> ReadFromFile()
        {
            List<CountriesTextFile> CountryList = new List<CountriesTextFile>();

            string fileLocation = "../../countries.txt";

            StreamReader reader = new StreamReader(fileLocation);

            reader.Close();
            return CountryList;
        }

    public AddToTextFile(string Countries) : base(Countries)

        {

    }

    public static void WriteDataToFile(string inputCountry)
    {
        StreamWriter sw = new StreamWriter("../../DataFile.txt", true);

        foreach (countries c1 in CountriesTextFile)
        {

            //3 ways:
            //Console.WriteLine(Emp.Name1 + "=>" + Emp.Salary1);
            //Console.WriteLine($"Name: {Emp.Name1}, Salary:{Emp.Salary1}");
            // Console.WriteLine("Name:{0}, Salary:{1}", Emp.Name1, Emp.Salary1);
        }

       sw.Write($"\n{inputCountry}");
        sw.Close();




    }
}

