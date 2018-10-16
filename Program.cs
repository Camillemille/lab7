using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {

            string userName = nameValidation();
            Console.WriteLine(userName + (" ")+ "what's your email?");
            string userEmail = emailValidation();
            string userPhoneNumber = phoneNumberValidation();
            string userDateInput = dateValidation();
            


        }

        public static string nameValidation()
        {
            Console.WriteLine("What is your name?");
            // input
            string userName = Console.ReadLine();
            if (Regex.IsMatch(userName, @"^[A-Z]+[A-z]{2,30}$")== false)
            {
                Console.WriteLine("I'm sorry! That's not a name.");
                
                do
                {
                    Console.WriteLine("Please enter a vaild name."); //Traps the user until enters a valid name.
                    userName = Console.ReadLine(); 
                } while (Regex.IsMatch(userName, @"^[A-Z]+[A-z]{2,30}$") == false);
                
            } 
           
            else 
            {

                Console.WriteLine("Thanks Username accepted!");

            }
         
                
            //output
            return userName;
        }


        public static string emailValidation()
        {
            //Input
            string userEmail = Console.ReadLine();
            if (Regex.IsMatch(userEmail, @"^([A-Z0-9a-z]{5,30}@[A-Z0-9a-z]{5,10}.[A-Za-z]{2,3})$") == false)
            {
                Console.WriteLine("I'm sorry that is not a valid e-mail.");
                do
                {
                    Console.WriteLine("Please enter a vaild email.");
                    userEmail = Console.ReadLine();
                } while (Regex.IsMatch(userEmail, @"^([A-Z0-9a-z]{5,30}@[A-Z0-9a-z]{5,10}.[A-Za-z]{2,3})$") == false);
            }
            else
            {
                Console.WriteLine("Thanks, Email accepted!");

            }


            return userEmail; 



        }

        public static string phoneNumberValidation()
        {
            Console.WriteLine("What is your phone number?");
            string userPhoneNumber = Console.ReadLine();
            if (Regex.IsMatch(userPhoneNumber, @"^([0-9]{3}-[0-9]{3}-[0-9]{4})$") == false)
            {
                Console.WriteLine("I'm sorry that is not a valid phone number.");
                do
                {
                    Console.WriteLine("Please enter a vaild phone number.");
                    userPhoneNumber = Console.ReadLine();
                } while (Regex.IsMatch(userPhoneNumber, @"^([0-9]{3}-[0-9]{3}-[0-9]{4})$") == false);


            }
            else
            {
                Console.WriteLine("Thanks, phone number accepted!");
            }



            

            return userPhoneNumber;


        }





        public static string dateValidation()
        {
            Console.WriteLine("What is your Birthdate?");
            string userDateInput = Console.ReadLine();
            if (Regex.IsMatch(userDateInput, @"^(0[1-9]|1[012])[/](0[1-9]|[12][0-9]|3[01])[/](19|20)\d\d$") == false)
            {
                Console.WriteLine("I'm sorry that is not a valid date.");
                do
                {
                    Console.WriteLine("Please enter a valid date");
                    userDateInput = Console.ReadLine();


                } while (Regex.IsMatch(userDateInput, @"^(\([0 - 9]{ 2}\/[0 - 9]{ 2}\/[0 - 9]{ 4}\)$") == false);
            }
            else
            {

                Console.WriteLine("Thanks, date accepted!");


            }
                
         

            




                 return userDateInput;

        }


        
        
    }




}
