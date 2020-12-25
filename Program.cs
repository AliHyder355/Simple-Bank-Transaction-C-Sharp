using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.com.Practiceproject;

namespace OOP
{

    class Program
    {
        static void Main(string[] args)
        {

            Bank hbl = new Bank();

            hbl.Bms();
            hbl.ByeMsg();
            string np = hbl.inpp;


            if (np == "Y" || np == "y")
            {
                hbl.Bms();
            }



            else if (np != "N" || np == "n")
            {
                Console.WriteLine("Thank You, Bye Bye..!");
            }







            Console.ReadKey();

        }
    }
}
