using System;
using System.IO;
namespace UserSystem
{
    public static class fileManagement
    {
        public async static void UserFileAsync()
        {
            string path = @"../UserSystem/User.txt";
            /// <summary>
            /// it checks if the file exists, if it does. it continues the application, if it doesn't it creates it
            /// </summary>
            if(!File.Exists(path))
            {
                    /// <summary>
                   // clears the instance of stream writer the file for us after it runs
                    /// </summary>
                // clears the instance of stream writer the file for us after it runs
                using StreamWriter writefile = File.CreateText(path);
            }
                using(StreamWriter streamWriter = File.AppendText(path))
            {
                    streamWriter.WriteAsync(" Surname:");
                    streamWriter.WriteAsync("Name:, Email:, Surname:");
            }

            using (StreamReader streamReader = File.OpenText(path))
            {
                var read = await streamReader. ReadToEndAsync();
                read = read.TrimEnd();
                System.Console.WriteLine(read);


                var users = read.Split(Environment.NewLine);
                foreach (var item in users)
                {
                    var user = item.Split(',');
                    // System.Console.WriteLine(user[0]);
                    System.Console.Write("please enter first name: ");
                    System.Console.ReadLine();
                    // System.Console.WriteLine(user[1]);
                     System.Console.Write("please enter last name: ");
                     System.Console.ReadLine();
                    // System.Console.WriteLine(user[2]);
                    System.Console.Write("please enter email: ");
                  System.Console.ReadLine();
                  break;
                }
            }
        

        }
    }
}