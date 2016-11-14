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
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Countries Maintenance App!\n1 - See the list of Countries\n2 - Add a country\n3 - Exit");
            Console.WriteLine("Enter menu number");

            public int menu = int.Parse(Console.ReadLine());
            //CountriesApp menu1 = new CountriesApp();



            List<CountriesTextFile> CountriesTextFileList = new List<CountriesTextFile>();
            StreamWriter sw = new StreamWriter("../../countries.txt", true);

            //call countries app 

        }


    }

}
