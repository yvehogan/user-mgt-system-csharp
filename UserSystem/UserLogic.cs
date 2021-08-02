using System;
using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using System.IO;

namespace UserSystem
{
       /// <summary>
    /// Class that defines the user instance
    /// </summary>
    public class UserLogic
    {
        public static string FirstName { get; set; }

        public static string SecondName { get; set; }

        public static string Email { get; set; }

        public static string FavouriteFood { get; set; }

        public static void UserData()
        {

            {
                System.Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                userqueue<string> users = new userqueue<string>();
                Console.WriteLine("User Management System in C#\r");
                Console.WriteLine("------------------------\n");

                Console.WriteLine("Enter: ");
                Console.WriteLine("1 to Add");
                Console.WriteLine("2 to Display");
                Console.WriteLine("3 to Remove");
                Console.WriteLine("4 to exit");

                System.Console.Write("\r\nSelect an option: ");


                string userInput = System.Console.ReadLine();
                switch (userInput)
                {
                    case "1":

                    System.Console.Write("please enter first name: ");
                    FirstName = System.Console.ReadLine();

                    System.Console.Write("please enter last name: ");
                    SecondName = System.Console.ReadLine();

                    System.Console.Write("please enter email: ");
                    Email = System.Console.ReadLine();

                     System.Console.Write("please enter favourite food: ");
                    FavouriteFood = System.Console.ReadLine();

                    string[] userString = {FirstName, SecondName, Email, FavouriteFood};
                    string userDetails = $"{userString[0]} , {userString[1]} , {userString[2]} , {userString[3]}";
                    users.Enqueue(userDetails);
                    users.Print();

                    break;

                    case "2":
                    users.Print();
                    break;

                    case "3":
                    users.Dequeue();
                    users. Print();
                    break;

                    case "4":
                    Console.Clear();
                    break;

                    default:
                    System.Console.WriteLine("Please select a number from 1 to 4");
                    break;
                }

        }
    }
}
}
        