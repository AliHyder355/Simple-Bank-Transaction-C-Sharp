using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.com.Practiceproject
{
    class Bank
    {
        public string inpp = "";

        public void Bms()
        {

            String name = "";
            int num = 0;
            string date = "";

            bool val = true;
            do
            {
                Console.WriteLine("***SELECT ANY OPTION*** ");
                Console.WriteLine("_____________________________");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Check Your Account Deatails");
                Console.WriteLine("3. Create New Account");
                Console.WriteLine("4. Check Existing Account");
                Console.WriteLine("5. Press 5 to Exit");
                Console.WriteLine("_____________________________");
                int inp = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();

                if (inp == 1)
                {
                    Console.WriteLine("You Current Balance Is: 75000 PKR");
                }
                else if (inp == 2)
                {
                    Console.WriteLine("Account Holder: Ali Hyder");
                    Console.WriteLine("Account No: 02020320924");
                    Console.WriteLine("Acount Created: 22 July 2020");
                }
                else if (inp == 3)
                {
                    Console.WriteLine("Enter Your Name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter Phone No: ");
                    num = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Date: ");
                    date = Console.ReadLine();


                }

                else if (inp == 4)
                {
                    string n = name;
                    int number = num;
                    string dt = date;
                    Console.WriteLine("Account Holder:" + n);
                    Console.WriteLine("Account No: " + number);
                    Console.WriteLine("Acount Created: " + dt);
                }


                else if (inp == 5)
                {
                    val = false;
                }


                else
                {
                    Console.WriteLine("You Have Enter Invalid Entry Try Again..");
                }

                Console.WriteLine();
                Console.WriteLine("APP CREATED BY ALI HYDER");





            } while (val == true);

        }

        public void ByeMsg()
        {
            Console.WriteLine("Do You Want to Perform Another Transaction? (Y/N)");
            inpp = Console.ReadLine();


        }


    }
}
